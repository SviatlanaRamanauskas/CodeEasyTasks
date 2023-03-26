/*namespace Encapsulation
{
    class User
    {
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(_name))
                _name = value;
            }
        }
        public int Age { get; set; }
    }

    class ClassWithMain
    {
        static void Main(string[] args)
        { }
    }
}*/