using Notification.Lib.Abstraction;
using Notification.Lib.BusinessModel;

namespace Notification.Lib.Concretions
{
    public class SMSNotifier : Notifier
    {
        public override string Notify(Contact contact)
        {
             return "Notification sms sent to " + contact.Mobile.ToString();
        }
    }
}