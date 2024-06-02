using FactoryMethodDesignPattern.AbstractProduct;

namespace FactoryMethodDesignPattern.ConcreteProduct
{
    public class CreditCardPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment processing using Credit Card...Amount: ${amount}");
        }
    }
}
