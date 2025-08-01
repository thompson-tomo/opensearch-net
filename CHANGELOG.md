# CHANGELOG
Inspired from [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)

## [Unreleased]
### ⚠️ Breaking Changes ⚠️
- As part of [efforts to re-generate the client](https://github.com/opensearch-project/opensearch-net/pulls?q=is%3Apr+label%3Acode-gen+is%3Aclosed) from our [OpenAPI specification](https://github.com/opensearch-project/opensearch-api-specification) there have been numerous corrections and changes that resulted in breaking changes. Please refer to [UPGRADING.md](UPGRADING.md) for a complete list of these breakages and any relevant guidance for upgrading to this version of the client.

### Changed
- Changed the namespace client properties on `IOpenSearchClient` to return corresponding interfaces to better enable mocking & unit testing ([#646](https://github.com/opensearch-project/opensearch-net/pull/646))
- Changed `NeuralQuery`'s `ModelId` to be optional ([#917](https://github.com/opensearch-project/opensearch-net/pull/917))

### Added
- Added conditions to the Microsoft.CSharp, System.Buffers & System.Diagnostics.DiagnosticSource dependencies so that they are not included on net 6+ as the newer framework's natively provides those dependencies. ([#930](https://github.com/opensearch-project/opensearch-net/pull/930))
- Added support for Hybrid query ([#917](https://github.com/opensearch-project/opensearch-net/pull/917))
- Added support for `MaxDistance` and `MinScore` to `KnnQuery` ([#917](https://github.com/opensearch-project/opensearch-net/pull/917))

### Removed
- Removed support for the `net461` target ([#256](https://github.com/opensearch-project/opensearch-net/pull/256))
- Removed the `Features` API which is not supported by OpenSearch from the low-level client ([#331](https://github.com/opensearch-project/opensearch-net/pull/331))
- Removed the deprecated low-level `IndexTemplateV2` APIs in favour of the `ComposableIndexTemplate` APIs ([#437](https://github.com/opensearch-project/opensearch-net/pull/437))

### Fixed
- Fixed naming of `ClusterManagerTimeout` and `MasterTimeout` properties from `*TimeSpanout` in the low-level client ([#332](https://github.com/opensearch-project/opensearch-net/pull/332))

### Dependencies
- Bumps `System.Diagnostics.DiagnosticSource` from 6.0.1 to 8.0.1
- Bumps `YamlDotNet` from 16.0.0 to 16.3.0
- Bumps `AWSSDK.Core` from 3.7.400.11 to 4.0.0.16
- Bumps `Fake.Core.SemVer` from 6.1.0 to 6.1.3
- Bumps `Bogus` from 35.6.0 to 35.6.3
- Bumps `Fake.Core.Environment` from 6.1.0 to 6.1.3
- Bumps `FluentAssertions` from 6.12.0 to 8.5.0
- Bumps `Microsoft.NET.Test.Sdk` from 17.11.0 to 17.13.0
- Bumps `Microsoft.TestPlatform.ObjectModel` from 17.11.0 to 17.14.1
- Bumps `BenchMarkDotNet` from 0.13.12 to 0.15.0
- Bumps `Fake.IO.FileSystem` from 6.1.0 to 6.1.3
- Bumps `Fake.IO.Zip` from 6.1.0 to 6.1.3
- Bumps `Fake.Tools.Git` from 6.1.0 to 6.1.3
- Bumps `CSharpier.Core` from 0.29.1 to 1.0.3
- Bumps `Proc` from 0.8.1 to 0.9.1
- Bumps `System.Text.Json` from 8.0.4 to 8.0.6
- Bumps `JunitXml.TestLogger` from 4.0.254 to 6.1.0
- Bumps `FSharp.Core` from 8.0.400 to 9.0.300
- Bumps `JetBrains.Annotations` from 2024.2.0 to 2024.3.0
- Bumps `Microsoft.Extensions.Caching.Memory` from 6.0.0 to 8.0.1
- Bumps `xunit` from 2.8.0 to 2.9.3
- Bumps `System.Buffers` from 4.5.1 to 4.6.1
- Bumps `NSwag.Core` from 14.1.0 to 14.4.0
- Bumps `Argu` from 6.2.4 to 6.2.5
- Bumps `SemanticVersioning` from 2.0.2 to 3.0.0
- Bumps `FSharp.Data` from 6.4.0 to 6.6.0
- Bumps `Octokit` from 13.0.1 to 14.0.0
- Bumps `Spectre.Console` from 0.49.1 to 0.50.0
- Bumps `System.CommandLine.DragonFruit` from 0.3.0-alpha.20371.2 to 0.3.0-alpha.21216.1
- Bumps `DiffPlex` from 1.7.2 to 1.8.0
- Bumps `SharpYaml` from 2.1.1 to 2.1.3
- Bumps `System.CommandLine` from 2.0.0-beta4.22272.1 to 2.0.0-beta6.25358.103
- Bumps `Markdig` from 0.41.2 to 0.41.3

## [1.8.0]
### Added
- Added support for the `neural` query type and `text_embedding` ingest processor type ([#636](https://github.com/opensearch-project/opensearch-net/pull/636))
- Added support for the `Cat.PitSegments` and `Cat.SegmentReplication` APIs ([#527](https://github.com/opensearch-project/opensearch-net/pull/527))
- Added support for `MinScore` on `ScriptScoreQuery` ([#624](https://github.com/opensearch-project/opensearch-net/pull/624))
- Added support for serializing the `DateOnly` and `TimeOnly` types ([#734](https://github.com/opensearch-project/opensearch-net/pull/734))
- Added support for the `Ext` parameter on `SearchRequest` ([#738](https://github.com/opensearch-project/opensearch-net/pull/738))
- Added support for the `Indices.Stats` API ([#753](https://github.com/opensearch-project/opensearch-net/pull/753))

### Dependencies
- Bumps `AWSSDK.Core` from 3.7.204.12 to 3.7.400.11
- Bumps `Bogus` from 35.3.0 to 35.6.0
- Bumps `xunit` from 2.7.1 to 2.8.0
- Bumps `FSharp.Core` from 8.0.100 to 8.0.400
- Bumps `xunit.runner.visualstudio` from 2.5.8 to 2.8.2
- Bumps `CSharpier.Core` from 0.27.3 to 0.29.1
- Bumps `Spectre.Console` from 0.48.0 to 0.49.1
- Bumps `Nullean.VsTest.Pretty.TestLogger` from 0.3.0 to 0.4.0
- Bumps `Microsoft.NET.Test.Sdk` from 17.9.0 to 17.11.0
- Bumps `Microsoft.TestPlatform.ObjectModel` from 17.9.0 to 17.11.0
- Bumps `Octokit` from 11.0.0 to 13.0.1
- Bumps `System.Reactive` from 6.0.0 to 6.0.1
- Bumps `Argu` from 6.2.3 to 6.2.4
- Bumps `YamlDotNet` from 15.1.2 to 16.0.0
- Bumps `NSwag.Core` from 14.0.7 to 14.1.0
- Bumps `System.Text.Json` from 8.0.3 to 8.0.4
- Bumps `JetBrains.Annotations` from 2023.3.0 to 2024.2.0
- Bumps `JunitXml.TestLogger` from 3.1.12 to 4.0.254
- Bumps `Fake.Core.SemVer` from 6.0.0 to 6.1.0
- Bumps `Fake.Core.Environment` from 6.0.0 to 6.1.0
- Bumps `Fake.IO.FileSystem` from 6.0.0 to 6.1.0
- Bumps `Fake.IO.Zip` from 5.23.1 to 6.1.0
- Bumps `Fake.Tools.Git` from 5.23.1 to 6.1.0

## [1.7.1]
### Fixed
- Fixed the deserialization of S3 snapshot repositories without settings ([#587](https://github.com/opensearch-project/opensearch-net/pull/587))

### Dependencies
- Bumps `System.Diagnostics.DiagnosticSource` from 6.0.1 to 8.0.0
- Bumps `System.Text.Json` from 8.0.1 to 8.0.3
- Bumps `Argu` from 6.2.1 to 6.2.3
- Bumps `FSharp.Data` from 6.3.0 to 6.4.0
- Bumps `NSwag.Core.Yaml` from 14.0.3 to 14.0.7
- Bumps `DiffPlex` from 1.7.1 to 1.7.2
- Bumps `JunitXml.TestLogger` from 3.0.134 to 3.1.12
- Bumps `Octokit` from 10.0.0 to 11.0.0
- Bumps `xunit` from 2.7.0 to 2.7.1
- Bumps `xunit.runner.visualstudio` from 2.5.7 to 2.5.8

## [1.7.0]
### Added
- Added `.Strict(...)`, `.Verbatim(...)`, `.Name(...)` methods on `QueryContainer` to help modify contained query attributes  ([#509](https://github.com/opensearch-project/opensearch-net/pull/509))

### Fixed
- Fixed `HttpConnection.ConvertHttpMethod` to support `Patch` method ([#489](https://github.com/opensearch-project/opensearch-net/pull/489))
- Fixed `IEnumerable<int?>` property mapping. ([#503](https://github.com/opensearch-project/opensearch-net/pull/503))
- Fixed `ConnectionConfiguration.DefaultMemoryStreamFactory` actually used as default. ([#552](https://github.com/opensearch-project/opensearch-net/pull/552))
- Fixed passing `"auto"` to the `slices` parameter ([#553](https://github.com/opensearch-project/opensearch-net/pull/553))

### Dependencies
- Bumps `NSwag.Core.Yaml` from 13.19.0 to 14.0.3
- Bumps `CSharpier.Core` from 0.25.0 to 0.27.3
- Bumps `System.Text.Encodings.Web` from 7.0.0 to 8.0.0
- Bumps `xunit.runner.visualstudio` from 2.5.4 to 2.5.7
- Bumps `xunit` from 2.6.2 to 2.7.0
- Bumps `Argu` from 6.1.1 to 6.2.1
- Bumps `Microsoft.NET.Test.Sdk` from 17.7.2 to 17.9.0
- Bumps `JetBrains.Annotations` from 2023.2.0 to 2023.3.0
- Bumps `Bogus` from 34.0.2 to 35.3.0
- Bumps `Octokit` from 9.0.0 to 10.0.0
- Bumps `FSharp.Core` from 8.0.100 to 8.0.101
- Bumps `Proc` from 0.6.2 to 0.8.1
- Bumps `System.Text.Json` from 8.0.0 to 8.0.1
- Bumps `Bullseye` from 4.2.1 to 5.0.0
- Bumps `BenchMarkDotNet` from 0.13.11 to 0.13.12
- Bumps `Microsoft.TestPlatform.ObjectModel` from 17.8.0 to 17.9.0
- Bumps `SharpYaml` from 2.1.0 to 2.1.1

## [1.6.0]
### Added
- Added support for point-in-time search and associated APIs ([#405](https://github.com/opensearch-project/opensearch-net/pull/405))
- Added support for the component template APIs ([#411](https://github.com/opensearch-project/opensearch-net/pull/411))
- Added support for the composable index template APIs ([#437](https://github.com/opensearch-project/opensearch-net/pull/437))
- Added high-level DSL for raw HTTP methods ([#447](https://github.com/opensearch-project/opensearch-net/pull/447))

### Deprecated
- Deprecated the low-level `IndexTemplateV2` APIs in favour of the new `ComposableIndexTemplate` APIs ([#454](https://github.com/opensearch-project/opensearch-net/pull/454))

### Dependencies
- Bumps `FSharp.Data` from 6.2.0 to 6.3.0
- Bumps `BenchMarkDotNet` from 0.13.7 to 0.13.11
- Bumps `AWSSDK.Core` from 3.7.202.1 to 3.7.204.12
- Bumps `xunit.runner.visualstudio` from 2.5.0 to 2.5.4
- Bumps `Octokit` from 7.1.0 to 9.0.0
- Bumps `FSharp.Core` from 7.0.400 to 8.0.100
- Bumps `xunit` from 2.4.2 to 2.6.2
- Bumps `Microsoft.TestPlatform.ObjectModel` from 17.7.2 to 17.8.0
- Bumps `System.Text.Json` from 7.0.3 to 8.0.0
- Bumps `Microsoft.SourceLink.GitHub` from 1.1.1 to 8.0.0

## [1.5.0]
### Fixed
- Fix highlight max_analyzer_offset field name to match with the one introduced in OpenSearch 2.2.0 ([#322](https://github.com/opensearch-project/opensearch-net/pull/322))
- Fix null-ref exception when track total hits is disabled ([#341](https://github.com/opensearch-project/opensearch-net/pull/341))

### Dependencies
- Bumps `Microsoft.TestPlatform.ObjectModel` from 17.5.0 to 17.7.2
- Bumps `JunitXml.TestLogger` from 3.0.124 to 3.0.134
- Bumps `System.Reflection.Emit.Lightweight` from 4.3.0 to 4.7.0
- Bumps `BenchMarkDotNet` from 0.13.5 to 0.13.7
- Bumps `Microsoft.NET.Test.Sdk` from 17.6.2 to 17.7.2
- Bumps `AWSSDK.Core` from 3.7.106.29 to 3.7.202.1
- Bumps `Bullseye` from 3.3.0 to 4.2.1
- Bumps `xunit.runner.visualstudio` from 2.4.5 to 2.5.0
- Bumps `FluentAssertions` from 6.10.0 to 6.12.0
- Bumps `JetBrains.Annotations` from 2022.3.1 to 2023.2.0
- Bumps `Octokit` from 6.1.0 to 7.1.0
- Bumps `FSharp.Core` from 7.0.300 to 7.0.400

## [1.4.0]
### Added
- Added support for approximate k-NN search queries and k-NN vector index properties ([#215](https://github.com/opensearch-project/opensearch-net/pull/215))

### Dependencies
- Bumps `System.Reflection.Emit` from 4.3.0 to 4.7.0
- Bumps `Argu` from 5.5.0 to 6.1.1
- Bumps `Ben.Demystifier` from 0.1.4 to 0.4.1
- Bumps `System.Text.Json` from 7.0.1 to 7.0.3
- Bumps `Octokit` from 4.0.3 to 6.1.0
- Bumps `Fake.Core.Environment` from 5.23.1 to 6.0.0
- Bumps `Microsoft.TestPlatform.ObjectModel` from 17.4.1 to 17.5.0
- Bumps `SharpZipLib` from 1.4.1 to 1.4.2
- Bumps `AWSSDK.Core` from 3.7.103.17 to 3.7.106.29
- Bumps `Newtonsoft.Json` from 13.0.2 to 13.0.3
- Bumps `Microsoft.CSharp` from 4.6.0 to 4.7.0
- Bumps `FSharp.Data` from 5.0.2 to 6.2.0
- Bumps `BenchMarkDotNet` from 0.13.4 to 0.13.5
- Bumps `FSharp.Core` from 6.0.7 to 7.0.300
- Bumps `Microsoft.NET.Test.Sdk` from 17.4.1 to 17.6.2
- Bumps `Fake.IO.FileSystem` from 5.23.1 to 6.0.0
- Bumps `Microsoft.SourceLink.GitHub` from 1.0.0 to 1.1.1
- Bumps `System.Diagnostics.DiagnosticSource` from 6.0.0 to 6.0.1
- Bumps `System.Reactive` from 5.0.0 to 6.0.0
- Bumps `Proc` from 0.6.1 to 0.6.2

## [1.3.0]
### Added
- Added support for Amazon OpenSearch Serverless request signing ([#133](https://github.com/opensearch-project/opensearch-net/pull/133))

### Changed
- Updated SDK to .NET 6 ([#126](https://github.com/opensearch-project/opensearch-net/pull/126))

### Removed
- Removed `net461` target from internal packages ([#128](https://github.com/opensearch-project/opensearch-net/pull/128))

### Fixed
- Fixed parsing of date histogram buckets ([#131](https://github.com/opensearch-project/opensearch-net/pull/131))
- Allow passing both boolean and integer values to `TrackTotalHits` ([#121](https://github.com/opensearch-project/opensearch-net/pull/121))

### Security
- CVE-2019-0820: Removed transitive dependencies on `System.Text.RegularExpressions` from internal packages; **Client Not Impacted** ([#137](https://github.com/opensearch-project/opensearch-net/pull/137))

### Dependencies
- Bumps `SemanticVersioning` from 0.8.0 to 2.0.2
- Bumps `Microsoft.NET.Test.Sdk` from 16.5.0 to 17.4.1
- Bumps `Octokit` from 0.32.0 to 4.0.3
- Bumps `BenchMarkDotNet` from 0.13.1 to 0.13.4
- Bumps `System.Reactive` from 3.1.1 to 5.0.0
- Bumps `SharpZipLib` from 1.0.4 to 1.4.1 ([#136](https://github.com/opensearch-project/opensearch-net/pull/136))
- Bumps `FSharp.Core` from 4.7.0 to 6.0.7
- Bumps `FSharp.Data` from 3.1.1 to 5.0.2
- Bumps `AWSSDK.Core` from 3.7.12.11 to 3.7.103.17
- Bumps `JunitXml.TestLogger` from 2.1.78 to 3.0.124
- Bumps `Fake.*` from 5.15.0 to 5.23.1
- Bumps `ConfigureAwaitChecker.Analyzer` from 4.0.0 to 5.0.0.1
- Bumps `Bogus` from 22.1.2 to 34.0.2
- Bumps `ShellProgressBar` from 5.0.0 to 5.2.0
- Bumps `FluentAssertions` from 5.10.3 to 6.10.0
- Bumps `SharpYaml` from 1.6.5 to 2.1.0
- Bumps `Newtonsoft.Json` from 13.0.1 to 13.0.2
- Bumps `Fake.Core.SemVer` from 5.23.1 to 6.0.0
- Bumps `System.Diagnostics.DiagnosticSource` from 5.0.0 to 6.0.0
- Bumps `Microsoft.NETFramework.ReferenceAssemblies` from 1.0.0-preview.2 to 1.0.3

[Unreleased]: https://github.com/opensearch-project/opensearch-net/compare/v1.8.0...main
[1.8.0]: https://github.com/opensearch-project/opensearch-net/compare/v1.7.1...v1.8.0
[1.7.1]: https://github.com/opensearch-project/opensearch-net/compare/v1.7.0...v1.7.1
[1.7.0]: https://github.com/opensearch-project/opensearch-net/compare/v1.6.0...v1.7.0
[1.6.0]: https://github.com/opensearch-project/opensearch-net/compare/v1.5.0...v1.6.0
[1.5.0]: https://github.com/opensearch-project/opensearch-net/compare/v1.4.0...v1.5.0
[1.4.0]: https://github.com/opensearch-project/opensearch-net/compare/v1.3.0...v1.4.0
[1.3.0]: https://github.com/opensearch-project/opensearch-net/compare/v1.2.0...v1.3.0
