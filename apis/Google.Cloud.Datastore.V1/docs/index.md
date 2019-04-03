{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

# Getting started

See the [Datastore Quickstart](https://cloud.google.com/datastore/docs/quickstart) for an introduction with runnable code samples.

The [DatastoreDb](obj/api/Google.Cloud.Datastore.V1.DatastoreDb.yml)
class is provided as a wrapper for
[DatastoreClient](obj/api/Google.Cloud.Datastore.V1.DatastoreClient.yml),
simplifying operations considerably by assuming all operations act
on the same partition, and providing page streaming operations on
structured query results.

Several custom conversions, additional constructors,
factory methods (particularly on [Filter](obj/api/Google.Cloud.Datastore.V1.Filter.yml)
are provided to simplify working with the protobuf messages.

# Using the Datastore Emulator

This package does not automatically connect to an emulator via
environment variables. However, it is reasonably simple do so. If
you wish to automatically connect to an emulator, simply include the
following method in your code, and call that instead of
`DatastoreDb.Create`.

{{sample:DatastoreDb.EmulatorInit}}

Note that if you use this technique for automated testing with large
amounts of data, you may wish to write an alternative method that
*only* connects to the emulator and fails if the emulator has not
been configured. That avoids accidentally connecting to the
production Datastore service and potentially incurring large bills
due to forgetting to set an environment variable.

# Sample code

## Inserting data

{{sample:DatastoreDb.InsertOverview}}

## Querying data

{{sample:DatastoreDb.QueryOverview}}

When a query contains a projection, any timestamp fields will be
returned using integer values. Use the
`Value.ToDateTimeFromProjection` and
`Value.ToDateTimeOffsetFromProjection` methods to convert
either integer or timestamp values to `DateTime` or `DateTimeOffset`.

Lots more samples:
[github.com/googleapis/dotnet-docs-samples](https://github.com/googleapis/dotnet-docs-samples/tree/master/datastore/api)
