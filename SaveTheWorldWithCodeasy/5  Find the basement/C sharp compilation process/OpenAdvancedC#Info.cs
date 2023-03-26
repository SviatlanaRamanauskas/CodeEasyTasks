using System;

namespace OpenAdvancedInfo
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());// Write your code here
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = 0;

            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);

            if (b != 0)
            {
                quotient = a / b;
                Console.WriteLine(quotient);
            }
            else
            {
                Console.WriteLine("Can't divide by zero!");
            }
        }
    }
}
