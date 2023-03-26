using System;

namespace ConsoleInput
{
    public class TheMiddle
    {
        public static void Main(string[] args)
        {
            string aString = Console.ReadLine(); // Read a line from the console
            string bString = Console.ReadLine(); // Read a line from the console
            string cString = Console.ReadLine(); // Read a line from the console

            int a = int.Parse(aString);// Convert aString to an integer
            int b = int.Parse(bString);// Convert bString to an integer
            int c = int.Parse(cString);// Convert cString to an integer

            if ((a < b) && (b < c))
            {
                Console.WriteLine(b);
            }
            else if ((b < a) && (a < c))
            {
                Console.WriteLine(a);
            }
            else if ((a < c) && (c < b))
            {
                Console.WriteLine(c);
            }
        }
    }
}
