using FactoryMethodDesignPattern_LiveExample.Creator;

namespace FactoryMethodDesignPattern_LiveExample.Client
{
    public class NotificationManager
    {
        public void NotifyUser(NotifierCreator creator, string message)
        {
            var notifier = creator.CreateNotifier();
            notifier.SendNotification(message);
        }
    }
}
