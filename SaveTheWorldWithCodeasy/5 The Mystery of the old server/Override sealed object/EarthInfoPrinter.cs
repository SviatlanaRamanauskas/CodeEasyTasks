using System;

namespace Inheritance
{
    public class Planet
    {
        public Planet( int radius, string name, bool isHabitable)
        {
            RadiusInKm = radius;
            Name = name;
            IsHabitable = isHabitable;
        }

        protected int RadiusInKm;
        protected string Name;
        protected bool IsHabitable;
    }

    public class Earth : Planet
    {
        public Earth(int radius, string name, bool isHabitable) 
            : base(radius, name, isHabitable) // Call constructor from Planet
        { }

        public void PrintInfo()
        {
            Console.WriteLine($"Planet's name:\t\t{Name}");
            Console.WriteLine($"Radius in kilometers:\t{RadiusInKm}");

            if (IsHabitable)
                Console.WriteLine("This planet is habitable.");
            else
                Console.WriteLine("This planet is not habitable.");
        }
    }

    public class EarthInfoPrinter
    {
        public static void Main()
        {
            var earth = new Earth(6371, "Earth", true);
            earth.PrintInfo();
        }
    }
}