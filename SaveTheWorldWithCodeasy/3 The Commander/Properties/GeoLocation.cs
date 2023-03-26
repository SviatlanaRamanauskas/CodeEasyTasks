using System;

namespace Properties
{
    class ResistanceBase
    {
        public int Capacity { get; }
        public string Identifier { get; private set; }

        public GeoLocation Location { get; set; }
    }
    class GeoLocation
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}