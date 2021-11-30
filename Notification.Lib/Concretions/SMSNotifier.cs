using Notification.Lib.Abstraction;

namespace Notification.Lib.Concretions
{
    public class SMSNotifier : Notifier
    {

        public override string NotifyViaEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public override string NotifyViaSMS(string mobile)
        {   
            return "Notification SMS sent to "+mobile;
        }
    }
}