using System;

namespace Modulus
{
    class AntiMindReaders
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if ((number % 13) == 0)
                    Console.WriteLine("Infected!");
                else
                    Console.WriteLine("Nice one!");
            }
        }
    }
}