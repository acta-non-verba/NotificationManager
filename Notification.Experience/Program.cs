﻿using System;
using Notification.Lib.Abstraction;
using Notification.Lib.BusinessModel;
using Notification.Lib.Concretions;
namespace Notification.Experience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notify using Email/Whatsapp[E/S?] ");
            string notificationTarget = Console.ReadLine();
            Contact contact=new Contact("Vikas Joshi","vikas.joshi@live.com",9893497360);
            string notificationStatus="";
            switch (notificationTarget.ToLower())
            {
                case "e":
                    INotifiable emailNotifier = new EmailNotifier();
                    emailNotifier.Notify(contact);
                    break;
                case "w":
                    INotifiable whatsappNotifier = new WhatsappNotifier();
                    whatsappNotifier.Notify(contact);
                    break;
                default:
                    INotifiable SMSNotifier=new SMSNotifier();
                    SMSNotifier.Notify(contact);
                    break;
            }
            Console.WriteLine(notificationStatus);
        }
    }
}
