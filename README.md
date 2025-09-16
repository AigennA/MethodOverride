# MethodOverride
# NameFormatting
A C# project for handling different name formatting with method overloading.

## Features
The project contains three different methods for formatting names:
- Combine first and last name
- Handle first, middle, and last name
- Format names in uppercase

## Installation
1. Clone the project:
   ```bash
   git clone https://github.com/[your-username]/NameFormatting.git
   ```
2. Open the project in Visual Studio
3. Build the solution to use the code

## Usage
The methods can be called in the following ways:

```csharp
// First and last name
string simpleName = FormatName("Maria", "Johansson");

// First, middle, and last name
string fullName = FormatName("Maria", "Eva", "Johansson");

// Uppercase name
string uppercaseName = FormatName("Maria", "Johansson", true);
```

## Method Overloading
The project demonstrates method overloading in C#, where multiple methods can have the same name but different parameters. This makes the code more readable and maintainable.

## Testing
The project includes examples of usage in the `Main` method that shows all three formatting options.

## Contributing
To contribute to the project:
1. Create a new branch
2. Make your changes
3. Create a pull request
4. Wait for review

## License
The project is licensed under the MIT license.
