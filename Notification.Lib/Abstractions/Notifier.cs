

namespace Notification.Lib.Abstraction
{
    public abstract class Notifier
    {
        public abstract string NotifyViaEmail(string email);
        public abstract string NotifyViaSMS(string mobile);
    }
}