using System;

namespace Encapsulation
{
    class Good
    {
        public string Identifier { get; set; }
        public bool AlreadyAssigned { get; private set; }
        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            { 
                if (!AlreadyAssigned)
                {
                    _price = value;
                }
                AlreadyAssigned = true;
            }
        }
    }

    class ClassWithMain
    {
        static void Main(string[] args)
        {
            var good = new Good
            {
                Identifier = Console.ReadLine(),
                Price = double.Parse(Console.ReadLine())
            };

            DecreasePrice(good);

            Console.WriteLine($"I can buy {good.Identifier} for {good.Price}.");
        }

        private static void DecreasePrice(Good good)
        {
            good.Price -= 1.0;
        }
    }
}