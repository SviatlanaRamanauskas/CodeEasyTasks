using System;

namespace CharType
{
    class OutputCharacterNumber
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(sentence[n - 1]);
        }
    }
}