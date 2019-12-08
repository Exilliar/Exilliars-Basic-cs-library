# Exilliars-Basic-cs-library
Exilliar's basic c# library containing some basic methods that are regularly used in simple projects

# NuGet commands
To test use command:  
`dotnet test ExBCSL.testing/ExBCSL.testing.csproj`


After making updates make sure to update version number and run `dotnet pack` in the `/ExBCSL` file (you might need to delete previous nupkg files, not sure why)


To install the library use command `dotnet add {app-name} package ExBCSL`


To make sure that the latest version is install use command `dotnet restore` in the app directory


To push the package use command when in `ExBCSL/bin/Debug`:  
`dotnet nuget push ExBCSL.[version].nupkg -k [API key] -s https://api.nuget.org/v3/index.json`


# Methods
## BRead.cs
`string getString(string msg)`
    Gets a string from the command line

`int getInt(string msg)`
    Gets an int from the command line

## BArrays.cs
`string[] FillArr(string[] a0, string[] a1, int limit)`
    Fills one array with another, up to a set limit. Takes an input of an array in order to get size. Arrays must be strings

`int[] BBubbleSort(int[] a)`
    Runs a basic bubble sort. Orders from highest to lowest