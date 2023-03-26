using System;

namespace InputValidation
{
    class IDontEvenKnowMyName
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();

            while (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || firstName.Length < 2 || lastName.Length < 2)
            {
                if (string.IsNullOrEmpty(firstName))
                    Console.WriteLine($"First name can't be empty! Try again.");
                else if (firstName.Length < 2)
                    Console.WriteLine($"First name is too short! Try again.");
                if (string.IsNullOrEmpty(lastName))
                    Console.WriteLine($"Last name can't be empty! Try again.");
                else if (lastName.Length < 2)
                    Console.WriteLine($"Last name is too short! Try again.");
                firstName = Console.ReadLine();
                lastName = Console.ReadLine();
            }
            Console.WriteLine($"My greetings, {firstName} {lastName}!");
        }
    }
}