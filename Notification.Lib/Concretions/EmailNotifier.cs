

using Notification.Lib.Abstraction;

namespace Notification.Lib.Concretions
{
    public class EmailNotifier : Notifier
    {
        public override string Notify(string medium)
        {
             return "Notification email sent to "+medium;
        }
    }
}