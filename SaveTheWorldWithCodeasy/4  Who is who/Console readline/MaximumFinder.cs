using System;

namespace ConsoleInput
{
    public class TheMaximum
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());// Read a line and convert it to int (short version)
            int b = int.Parse(Console.ReadLine());// Read a line and convert it to int (short version)

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
