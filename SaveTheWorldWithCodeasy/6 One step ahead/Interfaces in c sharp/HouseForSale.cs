using System;

namespace Interfaces
{
    public interface IHouseForSale
    {
        decimal Price { get; }
    }

    public interface IProperty
    {
        string Address { get; }
    }

    public class MyHouse : IHouseForSale, IProperty
    {
        public decimal Price
        {
            get
            {
                return 10000000.0m;
            }
        }

        public string Address
        {
            get
            {
                return "Lombard Street, 12";
            }
        }
    }

    public class AHouseForSale
    {
        public static void Main()
        {
            Console.WriteLine("Double inheritance is possible only for interfaces!");
        }
    }
}