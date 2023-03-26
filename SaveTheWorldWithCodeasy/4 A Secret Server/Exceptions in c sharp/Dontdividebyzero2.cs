
using System;

namespace Exceptions
{
    public class DontDivideByZero2
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            try
            {
                var sum = a + b;
                Console.WriteLine(sum);
                var difference = a - b;
                Console.WriteLine(difference);
                var product = a * b;
                Console.WriteLine(product);
                var quotient = a / b;
                Console.WriteLine(quotient);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }

        }
    }
}