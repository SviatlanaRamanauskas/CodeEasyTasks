using System;

namespace InputValidation
{
    class WhatTimeIsItNow
    {
        static void Main(string[] args)
        {
            var hoursAsString = Console.ReadLine();
            var minutesAsString = Console.ReadLine();
            int hours;
            int minutes;
            bool valid = false;
            while (!valid)
            {
                if (!int.TryParse(hoursAsString, out hours) || !int.TryParse(minutesAsString, out minutes))
                {
                    valid = false;
                }
                else if (string.IsNullOrEmpty(hoursAsString) || (string.IsNullOrEmpty(minutesAsString)))
                {
                    valid = false;
                }
                else if ((hours > 23) || (hours < 0) || (minutes > 59) || (minutes < 0))
                {
                    Console.WriteLine("This is not a valid time. Try again!");
                    hoursAsString = Console.ReadLine();
                    minutesAsString = Console.ReadLine();
                }
                else if (int.TryParse(hoursAsString, out hours) || int.TryParse(minutesAsString, out minutes))
                {
                    valid = true;
                    Console.WriteLine($"The time is {hours}:{minutes}");
                }
                if (!valid)
                {
                    Console.WriteLine("This is not a valid time. Try again!");
                    hoursAsString = Console.ReadLine();
                    minutesAsString = Console.ReadLine();
                }

            }

        }
    }
}