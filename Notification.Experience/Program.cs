using System;
using Notification.Lib.Abstraction;
using Notification.Lib.BusinessModel;
using Notification.Lib.Concretions;
namespace Notification.Experience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notify using Email/SMS[E/S?] ");
            string notificationTarget = Console.ReadLine();
            Contact contact=new Contact("Vikas Joshi","vikas.joshi@live.com",9893497360);
            switch (notificationTarget.ToLower())
            {
                case "e":
                    Notifier emailNotifier = new EmailNotifier();
                    emailNotifier.Notify(contact);
                    break;
                case "s":
                    Notifier smsNotifier = new SMSNotifier();
                    smsNotifier.Notify(contact);
                    break;
                default:
                    break;
            }
        }
    }
}
