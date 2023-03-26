using System;

namespace CharType
{
    class MakeUpperCaseNotWar
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                char some = char.Parse(Console.ReadLine());
                if (char.IsUpper(some))
                    Console.WriteLine(some);
            }
        }
    }
}