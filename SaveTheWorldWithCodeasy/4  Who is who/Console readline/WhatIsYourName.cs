using System;

namespace ConsoleInput
{
    public class WhatIsYourName
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();// Read a line from the screen
            string secondName = Console.ReadLine();// Read a line from the screen

            Console.WriteLine($"Should I call you {firstName} or {secondName}?");
        }
    }
}