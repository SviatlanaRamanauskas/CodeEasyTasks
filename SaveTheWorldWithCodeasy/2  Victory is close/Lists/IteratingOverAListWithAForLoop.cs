using System;
using System.Collections.Generic;

namespace Lists
{
    public class ListsAnimals
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string> { "Wolf", "Fish", "Elephant", "Dog" };
            for (int i = 0; i < animals.Count; i++)
                Console.WriteLine(animals[i]);
        }
    }
}