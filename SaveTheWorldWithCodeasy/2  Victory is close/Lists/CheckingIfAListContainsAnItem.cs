using System;
using System.Collections.Generic;

namespace Lists
{
    public class PrepareForTheRaid
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            bool nameReal = true;
            while (nameReal)
            {
                string name = Console.ReadLine();
                if (name != "done")
                {
                    names.Add(name); ;
                }
                else
                {
                    nameReal = false;
                }
            }
            bool listContainSimon = names.Contains("Simon");
            if (listContainSimon)
            {
                Console.WriteLine("Team accepted");
            }
            else
            {
                Console.WriteLine("Team rejected");
            }
        }
    }
}