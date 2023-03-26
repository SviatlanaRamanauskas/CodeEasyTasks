namespace Inheritance
{
    class Building
    {
        public string Address { get; set; }
    }

    class Wall
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class SkyScraper : Building
    {
        public double Height { get; set; }
    }

    class ClimbingWall : Wall
    {
        int MinDifficulty { get; set; }
        int MaxDifficulty { get; set; }
    }

    public class IsA
    {
        public static void Main()
        { }
    }
}