using System;

namespace Inheritance
{
    public class Website
    {
        public Website(string name, string title, int yearCreated)
        {
            _name = name;
            _title = title;
            _yearCreated = yearCreated;
        }

        private string _name;
        private string _title;
        private int _yearCreated;

        public override string ToString()
        {
            return $"{_name}, created in {_yearCreated}, with a title {_title}";
        }
    }

    public class AWebsite
    {
        public static void Main()
        {
            var website = new Website("Codeasy", "Learn C# online!", 2016);
            Console.WriteLine(website);
        }
    }
}