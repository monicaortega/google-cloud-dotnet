﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.ReleaseManager.History;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class CommitMultipleCommand : CommandBase
    {
        public CommitMultipleCommand()
            : base("commit-multiple", "Commit the current set of changes to multiple projects with an appropriate commit message", "title")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string title = args[0];

            var diffs = FindChangedVersions();
            if (diffs.Count < 2)
            {
                throw new UserErrorException($"Can only automate a multi-package release commit with more than one release. Found {diffs.Count}. Did you mean 'commit'?");
            }
            if (diffs.Any(diff => diff.NewVersion is null))
            {
                throw new UserErrorException($"Cannot automate a release commit for a deleted API.");
            }

            var catalog = ApiCatalog.Load();

            var diffsWithHistory = diffs
                .Where(diff => !catalog[diff.Id].NoVersionHistory)
                .ToList();

            if (diffsWithHistory.Any(diff => !File.Exists(HistoryFile.GetPathForPackage(diff.Id))))
            {
                // Not a great message, but a very rare condition.
                throw new UserErrorException($"Not all expected history file paths exist.");
            }

            var diffHistoryPairs = diffsWithHistory
                .Select(diff => (diff, history: HistoryFile.Load(HistoryFile.GetPathForPackage(diff.Id))))
                .ToList();


            // Commit has three sections:
            // - User-provided title
            // - Lists of changes (one list per package that has history)
            // - List of released packages

            var lines = new List<string>();
            lines.Add(title);
            lines.Add("");

            foreach (var (diff, history) in diffHistoryPairs)
            {
                lines.Add($"Changes in {diff.Id} version {diff.NewVersion}:");
                lines.Add("");
                var section = history.Sections.FirstOrDefault(s => s.Version?.ToString() == diff.NewVersion);
                if (section is null)
                {
                    throw new UserErrorException($"Unable to find history file section for {diff.Id} version {diff.NewVersion}. Cannot automate a release commit in this state.");
                }
                lines.AddRange(section.Lines.Skip(2));
                lines.Add("");
            }

            lines.Add("Packages in this release:");
            foreach (var diff in diffs)
            {
                lines.Add($"- Release {diff.Id} version {diff.NewVersion}");
            }

            var message = string.Join("\n", lines);

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                RepositoryStatus status = repo.RetrieveStatus();
                // TODO: Work out whether this is enough, and whether we actually need all of these.
                // We basically want git add --all.
                AddAll(status.Modified);
                AddAll(status.Missing);
                AddAll(status.Untracked);
                repo.Index.Write();
                var signature = repo.Config.BuildSignature(DateTimeOffset.UtcNow);
                var commit = repo.Commit(message, signature, signature);
                Console.WriteLine($"Created commit {commit.Sha}. Review the message and amend if necessary.");

                void AddAll(IEnumerable<StatusEntry> entries)
                {
                    foreach (var entry in entries)
                    {
                        repo.Index.Add(entry.FilePath);
                    }
                }
            }
        }
    }
}
