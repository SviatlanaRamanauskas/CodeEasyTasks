using System;

namespace Inheritance
{
    class Employee
    {
        public string Department { get; set; }

        public void PrintDepartment()
        {
            Console.WriteLine($"My department is {Department}");
        }
    }

    class Programmer : Employee 
    {
        public bool IsDepartmentCorrect()
        {
            if (Department == "IT")
                return true;
            else
                return false;
        }
    }

    public class IsDepartmentCorrect
    {
        public static void Main()
        {
            var programmer = new Programmer
            {
                Department = Console.ReadLine()
            };

            Console.WriteLine(programmer.IsDepartmentCorrect());
        }
    }
}