using System;

namespace ZanzibarGame
{
    public class Zanzibar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number");

            string inputAsString = Console.ReadLine();// Read a line from the screen
            int myNumber = int.Parse(inputAsString);// Convert inputAsString to int

            myNumber = myNumber + 1;
            // Do some magic with myNumber

            Console.WriteLine($"{myNumber}, I won!");
        }
    }
}