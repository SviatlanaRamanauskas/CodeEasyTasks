using System;

namespace Modulus
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}