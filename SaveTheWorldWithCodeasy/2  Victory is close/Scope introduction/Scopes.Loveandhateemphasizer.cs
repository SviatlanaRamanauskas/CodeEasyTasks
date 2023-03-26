using System;

namespace Scopes
{
    class LoveAndHateEmphasizer
    {
        static void Main(string[] args)
        {
            string whatILove = Console.ReadLine();
            string whatIHate = Console.ReadLine();

            string output = CombineString(whatILove, whatIHate);

            Console.WriteLine(output);
        }

        public static string CombineString(string love, string hate)
        {
            love = love.ToUpper();
            hate = hate.ToLower();

            return $"I love {love} but I hate {hate}.";
        }
    }
}