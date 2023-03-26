using System;

namespace Properties
{
    class ChickenFarm
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Capacity { get; }
        public string Identifier { get; private set; }
    }
}