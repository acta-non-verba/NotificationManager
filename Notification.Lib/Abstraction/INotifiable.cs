using Notification.Lib.BusinessModel;

namespace Notification.Lib.Abstraction
{
    public interface INotifiable
    {
        string Notify(Contact contact);
    }
}