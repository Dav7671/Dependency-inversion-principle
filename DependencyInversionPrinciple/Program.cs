using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger email = new Email();
            IMessenger sms = new Sms();
            IMessenger mms = new Mms();

            List<IMessenger> messengers = new List<IMessenger>();
            messengers.Add(email);
            messengers.Add(sms);
            messengers.Add(mms);

            // Constructor Injection
            for (int i = 0; i < messengers.Count; i++)
            {
                NotificationCI notificationCI = new NotificationCI(messengers[i]);
                notificationCI.Text = "News";
                notificationCI.DoNotify();
            }

            // Property Injection
            for (int i = 0; i < messengers.Count; i++)
            {
                NotificationPI notificationPI = new NotificationPI();
                notificationPI.MessageService = messengers[i];
                notificationPI.Text = "News";
                notificationPI.DoNotify();
            }

            // Method Injection
            for (int i = 0; i < messengers.Count; i++)
            {
                NotificationMI notificationMI = new NotificationMI();
                notificationMI.Text = "News";
                notificationMI.DoNotify(messengers[i]);
            }

            Console.ReadKey();
        }

    }
}
