using System;

namespace Null
{
    class AllDataInTheWorld
    {
        string _string;
        int _int;
        double _double;
        double[] _doubleArray;
        char _char;
        short _short;
        bool _bool;
        AllDataInTheWorld _allDataInTheWorld;

        public void PrintItAll()
        {
            if (_string == null)
                Console.WriteLine("I know initial value for type string!");

            if (_int == 0)
                Console.WriteLine("I know initial value for type int!");

            if (_double == 0)
                Console.WriteLine("I know initial value for type double!");

            if (_doubleArray == null)
                Console.WriteLine("I know initial value for arrays!");

            if (_char == 0)
                Console.WriteLine("I know initial value for type char!");

            if (_short == 0)
                Console.WriteLine("I know initial value for type short!");

            if (_bool == false)
                Console.WriteLine("I know initial value for type bool!");

            if (_allDataInTheWorld == null)
                Console.WriteLine("I know initial value for types created by the user!");
        }
    }

    class InitialValues
    {
        public static void Main()
        {
            var allDataInTheWorld = new AllDataInTheWorld();
            allDataInTheWorld.PrintItAll();
        }
    }
}