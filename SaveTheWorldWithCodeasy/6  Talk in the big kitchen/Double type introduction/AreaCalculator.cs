using System;

namespace DoubleType
{
    class AreaCalculator
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = pi * number * number;

            Console.WriteLine(area);
        }
    }
}