using FactoryMethodDesignPattern.AbstractFactory;
using FactoryMethodDesignPattern.AbstractProduct;

namespace FactoryMethodDesignPattern
{
    public class ECommercePlatform
    {
        public void Checkout(PaymentGatewayFactory factory, decimal amount)
        {
            IPaymentGateway paymentGateway = factory.CreatePaymentGateway();
            paymentGateway.ProcessPayment(amount);
        }
    }
}
