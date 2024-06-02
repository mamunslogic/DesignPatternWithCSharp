using FactoryMethodDesignPattern.AbstractProduct;

namespace FactoryMethodDesignPattern.ConcreteProduct
{
    public class PaypalPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment processing using Paypal...Amount: ${amount}");
        }
    }
}
