using System;

namespace Scopes
{
    class SumWithScopes
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            // Call method Add from class Calculator, namespace Mathematics here
            int sum = Mathematics.Calculator.Add(number1, number2);// Pass as arguments number1, number2 and put result in the sum variable

            Console.WriteLine(sum);
        }
    }
}

namespace Mathematics
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}