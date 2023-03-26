using System;

namespace Scopes
{
    class PrintHelloWithScopes
    {
        static void Main(string[] args)
        {
            Printer.PrintHello(); // Call PrintHello() here
        }
    }

    class Printer
    {
        public static void PrintHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}