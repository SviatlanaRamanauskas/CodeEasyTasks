using System;

namespace Exceptions
{
    public class GuessWhat
    {
        public static void Main()
        {
            Console.WriteLine("Input a secret number");
            while (true)
            {
                try
                {
                    var secretNumber = int.Parse(Console.ReadLine());
                    GuessingGame(secretNumber);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Your input is invalid. Try once again!");
                }
            }

        }

        private static void GuessingGame(int secretNumber)
        {
            Console.WriteLine("Now start guessing");
            var guessed = false;
            while (!guessed)
            {
                while (true)
                {
                    try
                    {
                        var number = int.Parse(Console.ReadLine());
                        if (number == secretNumber)
                            guessed = true;
                        else if (number > secretNumber)
                            Console.WriteLine("Smaller");
                        else
                            Console.WriteLine("Bigger");
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Your input is invalid. Try once again!");
                    }
                }

            }
            Console.WriteLine("You've guessed! Woohoo!");
        }
    }
}