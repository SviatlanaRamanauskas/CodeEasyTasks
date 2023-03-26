using System;

namespace Interfaces
{
    public interface IFactory
    {

        int NumberOfWorkers { get; }

        void GenerateGoods();
    }

    public class MainWrapper
    {
        public static void Main()
        {
            Console.WriteLine("I know interfaces!");
        }
    }
}