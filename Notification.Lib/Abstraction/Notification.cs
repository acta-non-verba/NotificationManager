using Notification.Lib.BusinessModel;

namespace Notification.Lib.Abstraction
{
    public interface INotifiable
    {
        string Notify(Contact contact);
    }

    public abstract class Notifier :INotifiable
    {
        public abstract string Notify(Contact contact);
    }
}