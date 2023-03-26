using System;

namespace SwitchStatement
{
    class DroneTrackingSystem
    {
        static void Main()
        {
            int x = 0;
            int y = 0;
            bool drone = false;
            while (!drone)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "up":
                        y++;
                        break;
                    case "right":
                        x++;
                        break;
                    case "diag":
                        y++;
                        x++;
                        break;
                    case "Destination reached.":
                        drone = true;
                        Console.WriteLine($"[{x}, {y}]");
                        break;
                }
            }
        }
    }
}