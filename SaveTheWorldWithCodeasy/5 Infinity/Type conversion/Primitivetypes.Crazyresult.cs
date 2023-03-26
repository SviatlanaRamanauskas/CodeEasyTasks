using System;

namespace PrimitiveTypes
{
    class CrazyResult
    {
        static void Main(string[] args)
        {
            short b = 200;
            short c = 10;
            byte a = (byte)(b + c);
            int d = (int)Math.PI + (int)a;

            Console.WriteLine($"The crazy result is {d}");
        }
    }
}