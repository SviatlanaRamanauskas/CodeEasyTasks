using System;

namespace This
{
    class AnotherDroid
    {
        private int secretNumber;

        public AnotherDroid(int secretNumber)
        {
            this.secretNumber = secretNumber;
        }

        public void GuessSecretNumber()
        {
            int secretNumber = -1;
            while (this.secretNumber != secretNumber)
            {
                Console.WriteLine("Input your guess [1..8]");
                secretNumber = int.Parse(Console.ReadLine());
                if (this.secretNumber != secretNumber)
                {
                    Console.WriteLine("Nope. Try again!");
                }
            }
            Console.WriteLine("You've guessed! Great work!");
        }
    }

    class HowToUseThis
    {
        public static void Main()
        {
            var droid = new AnotherDroid(6);
            droid.GuessSecretNumber();
        }
    }
}