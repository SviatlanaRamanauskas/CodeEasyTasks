using System;

namespace Modulus
{
    class UsageOfMathClass
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var thirdNumber = double.Parse(Console.ReadLine());
            var minimum = Math.Min(firstNumber, secondNumber);
            Console.WriteLine(Math.Pow(minimum, thirdNumber));
        }
    }
}