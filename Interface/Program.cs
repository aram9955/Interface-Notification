using System;
using System.Collections.Generic;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Notification notificationEmail = new Notification(new Email());
            Notification notificationDrone = new Notification(new Drone());
            Notification notificationSMS = new Notification(new SMS());
            Notification notificationEnvelop = new Notification(new Envelop());
            Notification notificationMMS = new Notification(new MMS());

            List<Notification> notifications = new List<Notification>();

            notifications.Add(notificationEmail);
            notifications.Add(notificationDrone);
            notifications.Add(notificationSMS);
            notifications.Add(notificationEnvelop);
            notifications.Add(notificationMMS);

            for (int i = 0; i < notifications.Count; i++)
            {
                notifications[i].DoNotify();
            }
        }
    }
}
