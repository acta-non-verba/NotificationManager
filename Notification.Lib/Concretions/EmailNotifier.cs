

using Notification.Lib.Abstraction;

namespace Notification.Lib.Concretions
{
    public class EmailNotifier : Notifier
    {

        public override string NotifyViaEmail(string email)
        {
            return "Notification email sent to "+email;
        }

        public override string NotifyViaSMS(string mobile)
        {
            throw new System.NotImplementedException();
        }
    }
}