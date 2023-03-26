using System;

namespace Booleans
{
    public class WeatherMatchingCloth
    {
        public static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());

            if (temperature <= 5)
            {
                Console.WriteLine("Wear a coat");
            }
            else
            {
                Console.WriteLine("Wear a jacket");
            }// Write your code here
        }
    }
}