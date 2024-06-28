using FactoryMethodDesignPattern_LiveExample.Product;

namespace FactoryMethodDesignPattern_LiveExample.ConcreteProduct
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending SMS: {0}", message);
        }
    }
}
