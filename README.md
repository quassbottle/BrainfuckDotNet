# BrainfuckDotNet
Simple Brainfuck compiler written on C# made generally for fun. (.NET Framework 6.0)

# Usage
To use it you have to run it using `dotnet run` command.
You can simply type the code into the console or specify the path of the file that contains the brainfuck code using the `--path` parameter.

# Usage in code
```csharp
Brainfuck brainfuck = new Brainfuck();
brainfuck.Run("put your code here");
```
Yeah. There is nothing special about using this brainfuck compiler.
