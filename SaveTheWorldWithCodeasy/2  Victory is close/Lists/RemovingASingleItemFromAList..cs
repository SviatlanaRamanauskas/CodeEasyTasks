using System;
using System.Collections.Generic;

namespace Lists
{
    public class ListsRemover
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>() { "England", "Sweden", "Uzbekistan", "London" };

            Console.WriteLine(countries[0]);
            Console.WriteLine(countries[1]);
            Console.WriteLine(countries[2]);
            Console.WriteLine(countries[3]);
            countries.Remove("London");

        }
    }
}