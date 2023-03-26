using System;

namespace Inheritance
{
    class Animal
    {
        public bool IsAlive { get; set; }
    }

    class Bird:Animal
    {
        public bool IsFlying { get; set; }
    }

    class Parrot:Bird
    {
        public void SayHi()
        {
            if (!IsAlive)
                return;
            else if (IsFlying)
                Console.WriteLine("Fleeeeeee");
            else if(IsAlive && !IsFlying)
                Console.WriteLine("Hi");
        }
    }

    public class WhatIsTransitive
    {
        public static void Main()
        {
            var parrot = new Parrot
            {
                IsAlive = true,
                IsFlying = false
            };

            parrot.SayHi();
        }
    }
}