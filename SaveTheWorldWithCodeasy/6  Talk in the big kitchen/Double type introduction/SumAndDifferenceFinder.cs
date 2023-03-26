using System;

namespace DoubleType
{
    class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
        }
    }
}