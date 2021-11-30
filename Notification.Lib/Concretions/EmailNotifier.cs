using Notification.Lib.Abstraction;
using Notification.Lib.BusinessModel;

namespace Notification.Lib.Concretions
{
    public class EmailNotifier : Notifier
    {
        public override string Notify(Contact contact)
        {
            return "Notification sent to "+contact.Email;
        }
    }
}