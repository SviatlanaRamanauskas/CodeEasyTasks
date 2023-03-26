/*namespace Encapsulation
{
    class GeoLocation
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public GeoLocation(double latitude, double longtitude)
        {
            Latitude = latitude;
            Longitude = longtitude;
        }
    }

    class Shop
    {
        public string Name { get; private set; }
        public decimal LastMonthRevenue { get; private set; }
        public GeoLocation Location { get; private set; }

        public Shop(string name, decimal lastMonthRevenue, GeoLocation location)
        {
            Name = name;
            LastMonthRevenue = lastMonthRevenue;
            Location = location;
        }
    }

    class ClassWithMain
    {
        static void Main(string[] args)
        { }
    }
}
*/