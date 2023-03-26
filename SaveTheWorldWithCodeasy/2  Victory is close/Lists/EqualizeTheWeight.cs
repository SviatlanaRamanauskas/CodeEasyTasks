using System;
using System.Collections.Generic;

namespace Lists
{
    public class EqualizeTheWeight
    {
        static void Main(string[] args)
        {
            List<int> weightAllBackpacks = new List<int>();
            int sum = 0;
            bool packs = true;
            while (packs)
            {
                string weightString = Console.ReadLine();
                if (weightString == "done")
                {
                    packs = false;
                }
                else
                {
                    int weight = int.Parse(weightString);
                    weightAllBackpacks.Add(weight);
                    sum = sum + weight;
                }
            }
            Console.WriteLine(sum / weightAllBackpacks.Count);// Your code here.
        }
    }
}