using System;

namespace LearningConst
{
    class BrokenVirus2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking rockets availability.");
            if (Console.ReadLine() == "available")
            {
                const double pi = 3.14159265358979323846;

                Console.WriteLine("Input rocket influence radius.");
                double radius = double.Parse(Console.ReadLine());
                double destroyArea = pi * radius * radius;

                Console.WriteLine($"Destroying area: {destroyArea}");
            }
            else
            {
                Console.WriteLine("Turning off.");
            }
        }
    }
}