namespace Inheritance
{
    public class ChocolateBar
    {
    }

    public class Snickers : ChocolateBar
    {
    }

    public class Twix : ChocolateBar
    {
    }

    public sealed class SnickersMax : Snickers
    {
    }

    public sealed class TwixExtra : Twix
    {
    }

    public sealed class MilkyWay : ChocolateBar
    {
    }

    public class ChocolatePerson
    {
        public static void Main()
        {
        }
    }
}