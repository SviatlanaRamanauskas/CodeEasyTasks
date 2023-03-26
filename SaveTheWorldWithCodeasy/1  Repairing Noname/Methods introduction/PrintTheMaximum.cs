using System;

namespace Methods
{
    class PrintTheMaximum
    {
        static void Main(string[] args)
        {
            PrintMax(75, 114);
        }

        static void PrintMax(int a, int b)
        {
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
    }
}