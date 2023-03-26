using System;

namespace ConsoleInput
{
    public class MoodChecker
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();

            if (answer == "fine")
            {
                Console.WriteLine("Life is great");
            }
            else
            {
                Console.WriteLine("Everything's gonna be alright");
            }
        }
    }
}