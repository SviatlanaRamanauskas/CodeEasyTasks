using System;

namespace CharType
{
    class DigitOrLetterDefiner
    {
        static void Main(string[] args)
        {
            int charCode = Console.Read();
            char theRealChar = Convert.ToChar(charCode);
            if (char.IsDigit(theRealChar))
            {
                Console.WriteLine("Digit");
            }
            if (char.IsLetter(theRealChar))
            {
                Console.WriteLine("Letter");
            }
            else
            {
                Console.WriteLine("Not a digit and not a letter");
            }
        }
    }
}