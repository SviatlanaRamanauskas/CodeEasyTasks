using System;

namespace ClassAndObject
{
    class Glass
    {
        public int LiquidLevel;
        public void Drink(int milliliters)   //  level becomes smaller on int mll number
        {
            LiquidLevel -= milliliters;
        }
        public void Refill()    //  level returns
        {
            if (LiquidLevel < 100)
                LiquidLevel = 200;
        }
    }
    public class RefillMyGlass
    {
        public static void Main()
        {
            Glass obj = new Glass();
            obj.LiquidLevel = 200;
            bool finish = false;
            while (!finish)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split(' ');
                if (parts[0] == "print")
                {
                    Console.WriteLine($"This glass contains {obj.LiquidLevel}ml of liquid.");
                }
                else if (parts[0] == "stop")
                {
                    finish = true;
                }

                else if (parts[0] == "drink")
                {
                    string number = parts[1];
                    int milliliters = int.Parse(number);
                    obj.Drink(milliliters);
                    obj.Refill();
                }

            }

        }
    }
}