using System;

namespace PrimitiveTypes
{
    class SaveEarth
    {
        static void Main(string[] args)
        {
            short count = short.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                if ((i % 2 == 0) && (i % 3 == 0))
                    Console.WriteLine("SaveEarth");
                else if (i % 2 == 0)
                    Console.WriteLine("Save");
                else if (i % 3 == 0)
                    Console.WriteLine("Earth");
                else if ((i % 2 != 0) || (i % 3 != 0) || ((i % 2 != 0) && (i % 3 != 0)))
                    Console.WriteLine(i);
            }

        }
    }
}