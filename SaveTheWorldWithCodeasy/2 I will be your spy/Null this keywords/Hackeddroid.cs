using System;

namespace Null
{
    class Droid
    {
        private Droid[] _neighbours;

        public Droid()
        { }

        public Droid(Droid[] neighbours) // constructor
        {
            _neighbours = neighbours;
        }

        public void BroadcastMessage(string message) // checking every letter
        {
            for (int i = 0; i < _neighbours.Length; i++)
            {
                _neighbours[i].ReceiveMessage(message);
            }
        }

        public void ReceiveMessage(string message) // check length
        {
            if (message.Length < 255)
                Console.WriteLine(message);
            else
                Console.WriteLine("Message is too long to display");
        }
    }

    class DestroyThemAll
    {
        public static void Main()
        {
            var droid1 = new Droid();
            var droid2 = new Droid();
            var droid3 = new Droid();
            var droid4 = new Droid();
            var droid5 = new Droid();
            var neighbours = new[] { droid1, droid2, droid3, droid4, droid5 };

            var hackedDroid = new Droid(neighbours);// created an object of Droid class

            hackedDroid.BroadcastMessage(null);// Write your code here. Broadcast a message on a hacked driod.
        }
    }
}