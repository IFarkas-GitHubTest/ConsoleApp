# ConsoleApp - Console app - .NET8

## Husky.Net

[Husky.Net](https://alirezanet.github.io/Husky.Net)

```shell
cd [Solution directory]
dotnet new tool-manifest --force
dotnet tool install Husky
dotnet husky install
```

## [ReSharper command line tools](https://www.jetbrains.com/help/resharper/ReSharper_Command_Line_Tools.html)

```shell
dotnet tool install -g JetBrains.ReSharper.GlobalTools
```

### [CleanupCode Command-Line Tool](https://www.jetbrains.com/help/resharper/CleanupCode.html)
[Doc](https://www.jetbrains.com/help/resharper/CleanupCode.html)

```shell
jb cleanupcode -p="BM: Full Cleanup" ConsoleApp.sln
```

## Build

Run in PowerShell as Admin

```shell
cd [project dir]
dotnet restore
dotnet build -c Release
```

## Conventional Commits

Read [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/#summary) summary.

## Install Git Extensions

Download from [here](https://github.com/gitextensions/gitextensions/releases/download/v4.2-rc1/GitExtensions-4.2.0.17539-d3b383c77.msi).
