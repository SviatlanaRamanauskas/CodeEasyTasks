using System;

namespace Interfaces
{
    public interface IMessage
    {
        string Type { get; }
        string Payload { get; }
        void Read(string payload);
    }

    public class Message : IMessage
    {
        private string _payload;
        public string Type
        {
            get
            {
                return "Encrypted message";
            }
        }

        public string Payload
        {
            get
            {
                return _payload;
            }
        }
        public void Read(string payload)
        {
            _payload = payload;
        }
    }

    public class EveryoneLikesSendingMessagesNowadays
    {
        public static void Main()
        {
            var message = new Message();

            message.Read("I will never implement methods and properties in an interface.");

            Console.WriteLine(message.Payload);
        }
    }
}