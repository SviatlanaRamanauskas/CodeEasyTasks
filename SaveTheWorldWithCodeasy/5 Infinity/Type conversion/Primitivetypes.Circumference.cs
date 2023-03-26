using System;

namespace PrimitiveTypes
{
    class Circumference
    {
        static void Main(string[] args)
        {
            float radius = float.Parse(Console.ReadLine());
            double pi = Math.PI;

            float result = 2.0f * (float)pi * radius;

            Console.WriteLine($"Circumference is {result}");
        }
    }
}