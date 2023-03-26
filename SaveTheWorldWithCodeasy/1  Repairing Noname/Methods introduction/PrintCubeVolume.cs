using System;

namespace Methods
{
    class CubeVolume
    {
        static void Main(string[] args)
        {
            double cubeEdgeSize = double.Parse(Console.ReadLine());
            PrintCubeVolume(cubeEdgeSize);
        }

        static void PrintCubeVolume(double cubeEdgeSize)
        {
            Console.WriteLine(cubeEdgeSize * cubeEdgeSize * cubeEdgeSize);
        }
    }
}