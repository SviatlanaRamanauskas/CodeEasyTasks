using System;

namespace WhileLoop
{
    class InfiniteDividor
    {
        static void Main(string[] args)
        {
            bool devidedByTwo = true;
            int number = int.Parse(Console.ReadLine());
            while (devidedByTwo)
            {
                if (number > 1)
                {
                    number = number / 2;
                    Console.WriteLine(number);
                }
                else
                {
                    devidedByTwo = false;
                }
            }

        }
    }
}