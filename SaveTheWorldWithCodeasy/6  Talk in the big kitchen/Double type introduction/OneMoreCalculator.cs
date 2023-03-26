using System;

namespace DoubleType
{
    class DoubleInLoops
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double number = double.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)

                Console.WriteLine(i + number);
        }
    }
}