using System;

namespace ConsoleInput
{
    public class WeightChecker
    {
        public static void Main(string[] args)
        {
            string numberOfBoxesString = Console.ReadLine();// Read a line from the console
            string weightString = Console.ReadLine();// Read a line from the console

            int numberOfBoxes = int.Parse(numberOfBoxesString);// Convert numberOfBoxesString to an integer
            int weight = int.Parse(weightString);// Convert weightString to an integer

            if ((numberOfBoxes * weight) < 30)
            {
                Console.WriteLine("Yes");// Write your logic here
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
