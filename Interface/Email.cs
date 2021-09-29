using System;

namespace Interface
{ 
    public class Email : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Email");
        }
    }
}
