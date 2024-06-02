using FactoryMethodDesignPattern.AbstractProduct;

namespace FactoryMethodDesignPattern.ConcreteProduct
{
    public class BitcoinPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment processing using Bitcoin...Amount: ${amount}");
        }
    }
}
