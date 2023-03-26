using System;

namespace Booleans
{
    class DogPersonTask
    {     
        static void Main(string[] args)
        {
            bool kittensAreNice = false;
            bool dogsAreNice = true;
            if (kittensAreNice)
            {
                Console.WriteLine("Turn on video with kittens!");
            }
            else
            {
                if (dogsAreNice)
                {
                    Console.WriteLine("I'm a dog person");
                }
            }
        }
    }
}