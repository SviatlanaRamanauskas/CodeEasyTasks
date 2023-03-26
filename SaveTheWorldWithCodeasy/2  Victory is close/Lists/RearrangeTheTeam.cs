using System;
using System.Collections.Generic;

namespace Lists
{
    public class RearrangeTheTeam
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();

            bool teamAges = true;
            while (teamAges)
            {
                string stringAge = Console.ReadLine();

                if (stringAge == "done")
                {
                    teamAges = false;
                }
                else
                {
                    int age = int.Parse(stringAge);
                    ages.Add(age);
                }
            }
            ages.Sort();
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

        }
    }
}