## Entity Framework - MySQL Connector - MaxScale proxy issue reproduction

This repo reproduces the issue of inserting records into a MySQL/MariaDB using the [EntityFrameworkCore MySQL connector](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql);

### Requirements
* [dotnet core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
  * To use a different SDK version, edit the `TargetFramework` property in `/MaxScaleProxyProblem/MaxScaleProxyProblem.csproj`
* dotnet cli

### Repro steps
1. Go into the project folder `/MaxScaleProxyProblem`
2. run `dotnet restore`
3. edit `MaxScaleProxyDbContext.cs` to add the db credentials on lines 10-13
4. run `dotnet run`
