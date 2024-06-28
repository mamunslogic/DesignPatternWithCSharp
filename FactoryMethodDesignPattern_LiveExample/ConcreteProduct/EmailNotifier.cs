using FactoryMethodDesignPattern_LiveExample.Product;

namespace FactoryMethodDesignPattern_LiveExample.ConcreteProduct
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Email: {0}", message);
        }
    }
}
