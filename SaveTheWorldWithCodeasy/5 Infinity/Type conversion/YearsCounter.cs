using System;

namespace PrimitiveTypes
{
    class HowManyYears
    {
        public static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            double years = (double)numberOfDays / 365;
            Console.WriteLine(years);// Write your code here
        }
    }
}