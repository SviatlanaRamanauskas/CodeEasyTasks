using System;

namespace DoubleType
{
    class OnlyNegative
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                double number = double.Parse(Console.ReadLine());
                double lessZero = 0;
                if (number < 0) // if -3.25<0
                {
                    lessZero = number;// -3.25
                    {
                        Console.WriteLine(lessZero);
                    }
                }
            }
        }
    }
}