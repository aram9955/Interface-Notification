using System;

namespace Interface
{
    public class Notification
    {
        private readonly  IMessage _message;
        public Notification(IMessage message)
        {
            _message = message;
        }
        public void DoNotify()
        {
            _message.SendMessage();
        }
    }
}
