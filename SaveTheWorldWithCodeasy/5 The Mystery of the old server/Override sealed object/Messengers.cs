using System;

namespace Inheritance
{
    public class Messenger
    {
        public virtual void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FacebookMessenger : Messenger
    {
        public sealed override void PrintMessage(string message)
        {
            Console.WriteLine("Facebook messenger: " + message);
        }
    }

    public class WhatsAppMessenger : Messenger
    {
        public sealed override void PrintMessage(string message)
        {
            Console.WriteLine("WhatsApp: " + message);
        }
    }

    public class Messengers
    {
        public static void Main()
        { }
    }
}