using System;

namespace InputValidation
{
    class Battleship
    {
        static void Main(string[] args)
        {
            var letterAsString = Console.ReadLine();
            var numberAsString = Console.ReadLine();

            char letter;
            int number;
            bool valid = false;
            while (!valid)
            {
                if (!char.TryParse(letterAsString, out letter) || !int.TryParse(numberAsString, out number))
                {
                    valid = false;
                }
                else if (string.IsNullOrEmpty(letterAsString) || (string.IsNullOrEmpty(numberAsString)))
                {
                    valid = false;
                }
                else if (!((letter >= 'a' && letter <= 'j') || (letter >= 'A' && letter <= 'J'))) // ((letter>= 'a' && letter <= 'j') || (letter>= 'A' && letter <= 'J'))
                {
                    valid = false;
                }
                else if ((number > 10) || (number < 1))
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                    Console.WriteLine($"Next move is {letter}{number}.");
                }
                if (!valid)
                {
                    Console.WriteLine($"Letter should be from A to J. Number from 1 to 10. Try again!");
                    letterAsString = Console.ReadLine();
                    numberAsString = Console.ReadLine();

                }
            }

        }
    }
}