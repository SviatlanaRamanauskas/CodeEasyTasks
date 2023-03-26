using System;

namespace Scopes
{
    class FixMe
    {
        static void Main(string[] args)
        {
            double moneyCount = double.Parse(Console.ReadLine());
            double treshold = 10.0;
            string myMaterialConditions;
            if (moneyCount > treshold)
            {
                myMaterialConditions = "rich";
            }
            else
            {
                myMaterialConditions = "poor";
            }

            Console.WriteLine($"I am {myMaterialConditions}.");
        }
    }
}