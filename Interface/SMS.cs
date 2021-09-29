using System;

namespace Interface
{
    public class SMS : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("SMS");
        }
    }
}
