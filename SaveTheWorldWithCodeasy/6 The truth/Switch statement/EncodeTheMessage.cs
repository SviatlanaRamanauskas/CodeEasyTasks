using System;

namespace SwitchStatement
{
    class SubstitutionCipher
    {
        static void Main()
        {
            string stringMessage = Console.ReadLine();
            char[] encodedMessage = new char[stringMessage.Length];
            for (int i = 0; i < stringMessage.Length; i++)
            {
                encodedMessage[i] = stringMessage[i];// created array
            }

            char[] encodedMessageLower = new char[encodedMessage.Length];
            for (int i = 0; i < stringMessage.Length; i++)
            {
                encodedMessageLower[i] = char.ToLower(stringMessage[i]);// created lower letter array for changing chars
            }

            for (int i = 0; i < encodedMessageLower.Length; i++) // analized every char in array enodedMessageLower and changed symbols
            {
                switch (encodedMessageLower[i])
                {
                    case 'f':
                        encodedMessage[i] = '!';
                        break;
                    case 'g':
                        encodedMessage[i] = '@';
                        break;
                    case 't':
                        encodedMessage[i] = '#';
                        break;
                    case 'h':
                        encodedMessage[i] = '$';
                        break;
                    case 'y':
                        encodedMessage[i] = '%';
                        break;
                    case 'b':
                        encodedMessage[i] = '^';
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(encodedMessage);// output encodedMessage, here Upper Letters saved 
        }
    }
}