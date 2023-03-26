using System;

namespace Static
{

    class Car
    {
        public static int CarsCount;
        public Car()
        {
            CarsCount++;
        }

    }

    class HowManyCars
    {
        public static void Main()
        {
            var car1 = new Car();
            var car2 = new Car();
            var car3 = new Car();
            var car4 = new Car();
            var car5 = new Car();

            Console.WriteLine($"Number of created cars is {Car.CarsCount}");
        }
    }
}