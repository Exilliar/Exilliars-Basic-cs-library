# Exilliars-Basic-cs-library
Exilliar's basic c# library containing some basic methods that are regularly used in simple projects

# NuGet commands
To test run:  
`dotnet test ExBCSL.testing/ExBCSL.testing.csproj`


After making updates make sure to update version number and run `dotnet pack` in the `/ExBCSL` file


To install the library use command `dotnet add {app-name} package ExBCSL`


To make sure that the latest version is install use command `dotnet restore` in the app directory


To push the package use command when in `ExBCSL/bin/Debug`:  
`dotnet nuget push ExBCSL.[version].nupkg -k [API key] -s https://api.nuget.org/v3/index.json`