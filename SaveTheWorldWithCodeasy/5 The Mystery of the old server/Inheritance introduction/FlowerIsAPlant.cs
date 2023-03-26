using System;

namespace Inheritance
{
    class Plant
    {
        public string Type { get; set; }

        public void PrintType()
        {
            Console.WriteLine($"Plant's type is: {Type}");
        }
    }

    class Flower : Plant
    {
        public string Color { get; set; }

        public void PrintColor()
        {
            Console.WriteLine($"Flower's color is: {Color}");
        }
    }

    public class ClassWithMain
    {
        public static void Main()
        {
            var flower = new Flower()
            {
                Color = "Red",
                Type = "Flowering"
            };

            flower.PrintType();
            flower.PrintColor();
        }
    }
}