# TinyUrlShortenerServiceApp
TinyUrlShortenerServiceApp is a simple console application to make an URL shortener

## Background
A [bijective function](https://en.wikipedia.org/wiki/Bijection) is necessary to find an inverse function g('abc') = 123 for our f(123) = 'abc' function.

We can start from a simple alphabet to use. For example the alphabet: [a-zA-Z0-9]. It contains 62 letters.
We can take an auto-generated, unique numerical key (the auto-incremented id of a SQL table for example).

For this example, I will use 12510 (125 with a base of 10).

Now you have to convert 12510 to X62 (base 62).

12510 = 2×621 + 1×620 = [2,1]

This requires the use of integer division and modulo. A pseudo-code example:

digits = []

while num > 0
  remainder = modulo(num, 62)
  digits.push(remainder)
  num = divide(num, 62)

digits = digits.reverse
Now map the indices 2 and 1 to your alphabet. This is how your mapping (with an array for example) could look like:

0  → a
1  → b
...
25 → z
...
52 → 0
61 → 9
With 2 → c and 1 → b, you will receive cb62 as the shortened URL.

http://shor.ty/cb

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

### Output Example
If you launch the console application by running:
```csharp
dotnet run --project TinyUrlShortenerServiceApp 123456789
```
then you'll see the following output:
```
Encoded URL: cbsd5j
Decoded URL: 123456789
```

### Structure of Project
TinyUrlShortenerServiceApp has only **1 project**;
* TinyUrlShortenerServiceApp
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

