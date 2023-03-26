using System;

namespace DoubleType
{
    class QuotientFinder
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine(a * b);//product 
                Console.WriteLine("Can't divide by zero!");
            }
            else
            {
                Console.WriteLine(a * b);//product 
                Console.WriteLine(a / b);//quotient
            }
        }
    }
}