using System;

namespace Interface
{
    public class MMS : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("MMS");
        }
    }
}
