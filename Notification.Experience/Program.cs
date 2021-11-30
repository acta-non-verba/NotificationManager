using System;
using Notification.Lib.Abstraction;
using Notification.Lib.Concretions;
namespace Notification.Experience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notify using Email/SMS[E/S?] ");
            string notificationTarget = Console.ReadLine();
            string notificationStatus="";
            switch (notificationTarget.ToLower())
            {
                case "e":
                    Notifier emailNotifier = new EmailNotifier();
                    notificationStatus=emailNotifier.NotifyViaEmail("vikas.joshi@live.com");
                    break;
                case "s":
                    Notifier smsNotifier = new SMSNotifier();
                    notificationStatus=smsNotifier.NotifyViaSMS("9893497360");
                    break;
                default:
                    break;
            }
            Console.WriteLine(notificationStatus);
        }
    }
}