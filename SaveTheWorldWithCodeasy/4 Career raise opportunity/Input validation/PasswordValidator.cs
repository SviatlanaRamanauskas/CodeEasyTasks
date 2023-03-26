using System;

namespace InputValidation
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (!PasswordIsValid(password))
            {
                if (password.Length < 8)
                    Console.WriteLine("Password length should be 8 symbols or more.");
                if (!ContainsUpperLetter(password))
                    Console.WriteLine("Password should contain at least one uppercase letter.");
                if (!ContainsLowerLetter(password))
                    Console.WriteLine("Password should contain at least one lowercase letter.");
                if (!ContainsDigit(password))
                    Console.WriteLine("Password should contain at least one digit.");
                password = Console.ReadLine();
            }
            Console.WriteLine("Your password is properly set!");
        }
        static bool ContainsUpperLetter(string password)
        {
            foreach (char c in password)
            {
                if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
                    return true;
            }
            return false;
        }

        static bool ContainsLowerLetter(string password)
        {
            foreach (char c in password)
            {
                if ((Char.IsLetter(c)) && (Char.IsLower(c)))
                    return true;
            }
            return false;
        }
        static bool ContainsDigit(string password)
        {
            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }
        static bool PasswordIsValid(string password)
        {
            if ((password.Length > 8) && ContainsUpperLetter(password) && ContainsLowerLetter(password) && ContainsDigit(password))
            {
                return true;
            }
            return false;
        }

    }
}