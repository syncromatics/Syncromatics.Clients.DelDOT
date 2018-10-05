# Delaware Department of Transportation Transit Arrivals API client

A .NET library to interact with the DelDOT arrivals api

## Quickstart

```bash
dotnet add package Syncromatics.Clients.DelDOT.Api
```

Then use it to do a thing:

```csharp
DelDOTClient client = new DelDOTClient();
StopArrivals arrivals = await client.GetStopArrivalsAsync(3832);
```

## Building

[![Travis](https://img.shields.io/travis/syncromatics/Syncromatics.Clients.DelDOT.svg)](https://travis-ci.org/syncromatics/Syncromatics.Clients.DelDOT)
[![NuGet](https://img.shields.io/nuget/v/Syncromatics.Clients.DelDOT.Api.svg)](https://www.nuget.org/packages/Syncromatics.Clients.DelDOT.Api/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Syncromatics.Clients.DelDOT.Api.svg)](https://www.nuget.org/packages/Syncromatics.Clients.DelDOT.Api/)

```
dotnet build
```

## Testing
```
dotnet test tests/Syncromatics.Clients.DelDOT.Api.Tests
```

## Code of Conduct

We are committed to fostering an open and welcoming environment. Please read our [code of conduct](CODE_OF_CONDUCT.md) before participating in or contributing to this project.

## Contributing

We welcome contributions and collaboration on this project. Please read our [contributor's guide](CONTRIBUTING.md) to understand how best to work with us.

## License and Authors

[![GMV Syncromatics Engineering logo](https://secure.gravatar.com/avatar/645145afc5c0bc24ba24c3d86228ad39?size=16) GMV Syncromatics Engineering](https://github.com/syncromatics)

[![license](https://img.shields.io/github/license/syncromatics/Syncromatics.Clients.DelDOT.svg)](https://github.com/syncromatics/Syncromatics.Clients.DelDOT/blob/master/LICENSE)
[![GitHub contributors](https://img.shields.io/github/contributors/syncromatics/Syncromatics.Clients.DelDOT.svg)](https://github.com/syncromatics/Syncromatics.Clients.DelDOT/graphs/contributors)

This software is made available by GMV Syncromatics Engineering under the MIT license.