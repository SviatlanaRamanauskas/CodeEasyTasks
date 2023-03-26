using System;

namespace ConsoleRead
{
    public class Greeting
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your name, please.");
            string name = Console.ReadLine();// Read a line from the screen
            Console.WriteLine($"My greetings, {name}!");
        }
    }
}