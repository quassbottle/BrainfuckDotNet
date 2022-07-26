using BrainfuckDotNet;

namespace BrainfuckDotNetCompiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BrainfuckDotNetCompiler";
            var b = new Brainfuck();
            if (args.Length != 0)
            {
                if ((args[0] == "--path" || args[0] == "--p") && args.Length > 1)
                {
                    string path = args[1];
                    using (var r = new StreamReader(path))
                    {
                        b.Run(r.ReadToEnd());
                        Console.Read();
                        return;
                    }
                }
                else
                {
                    string text = String.Join("", args);
                    b.Run(text);
                    Console.Read();
                    return;
                }
            }
            Console.WriteLine("Enter the Brainfuck code -> press enter -> then press Ctrl+Z (Ctrl+D for Linux users) -> enter");
            Console.WriteLine("Also you can specify the path with the code using the --path");
            Console.WriteLine("You can find all the information in the repository: https://github.com/quassbottle/BrainfuckDotNet/");
            Console.WriteLine("=========");
            b.Run(Console.In.ReadToEnd());
            Console.Read();
        }
    }
}