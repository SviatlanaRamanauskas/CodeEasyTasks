using System;

namespace This
{
    class AdvancedDroid
    {
        private string name;

        public AdvancedDroid(string name)
        {
            this.name = name;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello from {name}");
        }
    }

    class WhatIsThis
    {
        public static void Main()
        {
            AdvancedDroid droid = new AdvancedDroid("Cutie");
            droid.SayHello();
        }
    }
}