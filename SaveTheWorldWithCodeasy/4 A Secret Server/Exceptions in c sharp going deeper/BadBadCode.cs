using System;

namespace Exceptions
{
    public class BadBadCode
    {
        public static void Main()
        {
            try
            {
                int[] array = ReadArray();
                var secondBiggest = GetSecondBiggestNumber(array);

                Console.WriteLine(secondBiggest);
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static int[] ReadArray()
        {
            var numberOfElements = ReadInteger();

            try
            {
                var array = new int[numberOfElements];
                for (int i = 0; i < numberOfElements; i++)
                {
                    array[i] = ReadInteger();
                }

                return array;
            }
            catch
            {
                return null;  // 
            }
        }

        private static int GetSecondBiggestNumber(int[] array) //
        {
            if (array.Length < 2)
                throw new ArgumentException();

            Array.Sort(array);

            return array[2];
        }

        private static int ReadInteger()
        {
            return int.Parse(Console.ReadLine());// 
        }
    }
}