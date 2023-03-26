using System;

namespace Methods
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = Add(a, b);
            int difference = Subtract(a, b);
            int product = Multiply(a, b);
            int quotient = Divide(a, b);

            if (command == "add")
                Console.WriteLine(sum);
            if (command == "subtract")
                Console.WriteLine(difference);
            if (command == "multiply")
                Console.WriteLine(product);
            if (command == "divide")
                Console.WriteLine(quotient);

        }
        static int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        static int Subtract(int number1, int number2)
        {
            int difference = number1 - number2;
            return difference;
        }
        static int Multiply(int number1, int number2)
        {
            int product = number1 * number2;
            return product;
        }
        static int Divide(int number1, int number2)
        {
            int quotient = number1 / number2;
            return quotient;
        }
    }
}