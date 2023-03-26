using System;

namespace Interfaces
{
    public interface IVacuumCleaner
    {
        string Brand { get; }

        void Clean();
        void Stop();
        void GoBackToDock();
    }

    public class VacuumCleaner : IVacuumCleaner
    {
        public string Brand
        {
            get
            {
                return "Xiaomi";
            }
        }

        public void Clean()
        {
            // Do Work
        }

        public void GoBackToDock()
        {
            // Do Work
        }

        public void Stop()
        {
            // Do Work
        }
    }

    public class VacuumCleanerIsAlsoAMachine
    {
        public static void Main()
        {
            Console.WriteLine("Vacuum cleaner is also a machine.");
        }
    }
}