using Notification.Lib.BusinessModel;

namespace Notification.Lib.Abstraction
{

    public abstract class Notifier :INotifiable
    {
        public abstract string Notify(Contact contact);
    }
}