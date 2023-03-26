using System;

namespace Static
{
    static class DistanceMeasurer
    {
        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            double distance = 0;
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            distance = Math.Sqrt(x + y);

            return distance;
        }
    }

    class DistanceIsSoImportant
    {
        public static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine(DistanceMeasurer.GetDistance(x1, y1, x2, y2));
        }
    }
}