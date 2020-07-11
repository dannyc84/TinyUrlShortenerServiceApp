# TinyUrlShortenerServiceApp
QRCodeReaderApp is a simple web application to read QR Codes

## Getting Started
Use these instructions to get the project up and running.

### Prerequisites
You will need the following tools:

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 3.1 or later](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### Installing
Follow these steps to get your development environment set up:
1. Clone the repository
2. At the root directory, restore required packages by running:
```csharp
dotnet restore
```
3. Next, build the solution by running:
```csharp
dotnet build
```
4. Next, launch the console application by running:
```csharp
dotnet run --project TinyUrlShortenerServiceApp <"your identifier to convert">
```

### Structure of Project
TinyUrlShortenerServiceApp has only 1 layers that includes these folders
    * Interfaces    
    * Services
    
### Interfaces Folder
This folder contains the contract of the application service injected into the TinyUrlShortenerServiceApp.

### Services Folder
This folder contains the implementation of the application service injected into the TinyUrlShortenerServiceApp.

### Starting Point
The application's main **starting point** is the .NET Core console project. This is a classical console application, with a public static void Main method in Program.cs. It uses the Nuget package "Microsoft.Extensions.DependencyInjection" to set up Microsoft’s dependency injection container.

## Technologies
* .NET Core 3.1
* .NET Core Native DI

## Contributors

Thanks to the following people who have contributed to this project:

* [@dannyc84](https://github.com/dannyc84)

## Contact

If you want to contact me you can reach me at daniele.crivello84@libero.it.

## License

This project uses the following license: [MIT](LICENSE.md).

