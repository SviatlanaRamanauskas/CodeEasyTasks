using System;

namespace Polymorphism
{
    public interface IStringRule
    {
        bool AppliesToString(string input);
    }

    public class NoDoubleSpaces : IStringRule
    {
        public bool AppliesToString(string input)
        {
            if (input == null)
                return false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == ' ' && input[i + 1] == ' ')
                    return false;
            }

            return true;
        }
    }

    public class IsShort : IStringRule
    {
        public bool AppliesToString(string input)
        {
            return input != null && input.Length < 10;
        }
    }

    public class StringRules
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var hasNoDoubleSpaces = false;
            var isShort = false;

            // Write your code here
            NoDoubleSpaces rule1 = new NoDoubleSpaces();
            IsShort rule2 = new IsShort();

            hasNoDoubleSpaces = DoesTheRuleApply(rule1, input);
            isShort = DoesTheRuleApply(rule2, input);

            Console.WriteLine(hasNoDoubleSpaces);
            Console.WriteLine(isShort);
        }

        private static bool DoesTheRuleApply(IStringRule rule, string input)
        {
            return rule.AppliesToString(input);
        }
    }

}