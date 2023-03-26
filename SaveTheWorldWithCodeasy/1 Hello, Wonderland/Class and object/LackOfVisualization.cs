using System;

namespace ClassAndObjectAndAsciiArt
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
    public class LackOfVisualization
    {
        public static void Main()
        {
            /* Create object and read commands here */
            Glass obj = new Glass();
            obj.LiquidLevel = 200;
            bool finish = false;
            while (!finish)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split(' ');
                if (parts[0] == "print")
                {
                    if ((obj.LiquidLevel >= 150) && (obj.LiquidLevel < 200))
                    {
                        Console.WriteLine("|  |");
                        Console.WriteLine("|##|");
                        Console.WriteLine("|##|");
                        Console.WriteLine("|##|");
                    }
                    else if (obj.LiquidLevel == 200)
                    {
                        Console.WriteLine("|##|");
                        Console.WriteLine("|##|");
                        Console.WriteLine("|##|");
                        Console.WriteLine("|##|");
                    }
                    else if (obj.LiquidLevel < 150)
                    {
                        Console.WriteLine("|  |");
                        Console.WriteLine("|  |");
                        Console.WriteLine("|##|");
                        Console.WriteLine("|##|");
                    }
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