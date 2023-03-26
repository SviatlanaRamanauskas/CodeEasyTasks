using System;
using System.IO;

namespace Exceptions
{
    public class FinallyFinally
    {
        public static void Main()
        {
            NonamesFileReader fileReader = new NonamesFileReader();

            try
            {
                fileReader.OpenFile("D:/someFileFromTheServer.txt");
                var lineFromFile = fileReader.ReadLine();
                Console.WriteLine(lineFromFile);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading from someFileFromTheServer. Message = {e.Message}");
            }
            finally
            {
                fileReader.CleanUpAllResources();
            }
        }
    }

    class NonamesFileReader
    {
        StreamReader streamReader;

        public void OpenFile(string fileName)
        {
            streamReader = new StreamReader(fileName);
        }

        public string ReadLine()
        {
            return streamReader.ReadLine();
        }

        public void CleanUpAllResources()
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("Resources deallocated.");
        }
    }
}