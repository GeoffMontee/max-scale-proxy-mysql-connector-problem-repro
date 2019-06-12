## Entity Framework - MySQL Connector - MaxScale proxy issue reproduction

This repo reproduces the issue of inserting records into a MySQL/MariaDB using the [EntityFrameworkCore MySQL connector](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql);

### Requirements
* [dotnet core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
  * To use a different SDK version, edit the `TargetFramework` property in `/MaxScaleProxyProblem/MaxScaleProxyProblem.csproj`
* dotnet cli

### Repro steps
1. Go into the project folder `/MaxScaleProxyProblem`

2. Create the test table using the provided `insertScript.sql` SQL script:

```
mysql -u ${USER} -p ${DB} < insertScript.sql
```

3. Restore project dependencies using [dotnet restore](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x):

```
dotnet restore
```

4. edit `MaxScaleProxyDbContext.cs` to add the db credentials on lines 10-13

5. Run the project using [dotnet run](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run?tabs=netcore21):

```
dotnet run
```
