using System;

namespace Booleans
{
    public class ConsoleReadLine
    {
        public static void Main(string[] args)
        {
            string aString = Console.ReadLine(); // Read a line from the console
            string bString = Console.ReadLine();// Read a line from the console

            int a = int.Parse(aString);// Convert a string to an integer
            int b = int.Parse(bString);// Convert a string to an integer


            string operation = Console.ReadLine();// Read a line from the console

            string answer1 = "add";
            string answer2 = "multiply";

            if (operation == answer1)// Write an 'if' to check whether operation is "add" or "multiply"
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine(a * b);
            }
        }
    }
}
