using FactoryMethodDesignPattern_LiveExample.Product;

namespace FactoryMethodDesignPattern_LiveExample.ConcreteProduct
{
    public class PushNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Push Notification: {0}", message);
        }
    }
}
