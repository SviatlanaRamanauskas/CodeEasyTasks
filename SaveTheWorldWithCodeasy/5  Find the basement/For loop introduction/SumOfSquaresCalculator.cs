using System;

namespace ForLoops
{
    class SumOfSquares
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int minNumber = int.Parse(Console.ReadLine());
            int maxNumber = int.Parse(Console.ReadLine());

            for (int i = minNumber; i < maxNumber; i++)
            {
                sum = sum + i * i;
            }
            if (minNumber < maxNumber)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("min should be smaller than max!");
            }
        }
    }
}
