using System;

namespace SwitchStatement
{
    class DeliveryDrones
    {
        static void Main()
        {

            int distance = 0;
            bool drone = false;
            while (!drone)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "forward":
                        distance += 10;
                        break;
                    case "backward":
                        if (distance > 0)
                        {
                            distance -= 10;
                        }
                        else if (distance <= 0)
                        {
                            drone = true;
                            Console.WriteLine("Go back to base. Delivery failed.");
                        }
                        break;
                    case "Destination reached.":
                        drone = true;
                        Console.WriteLine(distance);
                        break;
                }
            }
        }
    }
}