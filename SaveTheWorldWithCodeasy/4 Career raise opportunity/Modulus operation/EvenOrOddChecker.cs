using System;

namespace Modulus
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int modul = number % 2;
            if (modul == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}