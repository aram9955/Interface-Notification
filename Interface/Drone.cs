using System;

namespace Interface
{
    public class Drone : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Drone");
        }
    }
}
