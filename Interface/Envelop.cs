using System;

namespace Interface
{
    public class Envelop : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Envelop");
        }
    }
}
