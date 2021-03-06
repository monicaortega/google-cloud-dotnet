﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using BreakingChangesDetector.MetadataItems;
using Microsoft.CodeAnalysis;
using Xunit;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class ConstructorDataTests
    {
        [Fact]
        public void ConstructorDataAccessibilityTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var members = typeData.GetMembers(".ctor");
            AssertX.Equal(3, members.Count, "Incorrect number of constructors returned.");
            AssertX.Equal(Accessibility.Public, ((ConstructorData)members[0]).Accessibility, "Incorrect Accessibility.");
            AssertX.Equal(Accessibility.Protected, ((ConstructorData)members[1]).Accessibility, "Incorrect Accessibility.");
            AssertX.Equal(Accessibility.ProtectedOrInternal, ((ConstructorData)members[2]).Accessibility, "Incorrect Accessibility.");
        }

        [Fact]
        public void ConstructorDataDeclaringTypeTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var constructor = typeData.GetMembers(".ctor")[0];
            AssertX.Equal(typeData, constructor.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
        }

        [Fact]
        public void ConstructorDataNameTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var constructor = typeData.GetMembers(".ctor")[0];
            AssertX.Equal(".ctor", constructor.Name, "The Name of the member is incorrect.");
        }

        [Fact]
        public void ConstructorDataParametersTest()
        {
            var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
            var members = typeData.GetMembers(".ctor");
            AssertX.Equal(3, members.Count, "Incorrect number of constructors returned.");
            AssertX.Equal(0, ((ConstructorData)members[0]).Parameters.Count, "The public constructor has the wrong number of parameters.");
            AssertX.Equal(2, ((ConstructorData)members[1]).Parameters.Count, "The protected constructor has the wrong number of parameters.");
            AssertX.Equal(3, ((ConstructorData)members[2]).Parameters.Count, "The protected internal constructor has the wrong number of parameters.");
        }
    }
}
