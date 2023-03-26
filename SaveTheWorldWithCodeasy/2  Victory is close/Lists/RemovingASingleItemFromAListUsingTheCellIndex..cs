using System;
using System.Collections.Generic;

namespace Lists
{
    public class ListsRemoverAtIndex
    {
        static void Main(string[] args)
        {
            List<string> programmingLanguages = new List<string> { "C", "C#", "C++" };
            programmingLanguages.RemoveAt(0);
            Console.WriteLine(programmingLanguages[0]);
            Console.WriteLine(programmingLanguages[1]);

        }
    }
}