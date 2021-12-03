

namespace Notification.Lib.Abstraction
{
    public interface INotifiable
    {
        string Notify(string email);
    }

    public abstract class Notifier : INotifiable
    {
        public abstract string Notify(string medium);
    }
}