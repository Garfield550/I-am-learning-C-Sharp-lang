using System;

namespace Delegate
{
    delegate void ConsoleWriteLine(string value);

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteLine cwl;
            cwl = new ConsoleWriteLine(MyConsole.WriteLine);

            cwl("Hello world!");

            Console.ReadKey();
        }
    }

    public class MyConsole
    {
        public static void WriteLine(string value)
        {
            Console.WriteLine("****************");
            Console.WriteLine(value);
            Console.WriteLine("****************");
        }
    }
}