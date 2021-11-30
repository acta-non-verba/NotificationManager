using Notification.Lib.BusinessModel;

namespace Notification.Lib.Abstraction
{
    public abstract class Notifier
    {
        public abstract string Notify(Contact contact);
    }
}