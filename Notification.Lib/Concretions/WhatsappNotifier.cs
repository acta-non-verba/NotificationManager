using Notification.Lib.Abstraction;

namespace Notification.Lib.Concretions
{
    public class WhatsappNotifier : Notifier
    {
        public override string Notify(string medium)
        {
            return "Notification SMS sent to "+medium1;
        }
    }
}