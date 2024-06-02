using FactoryMethodDesignPattern.AbstractProduct;

namespace FactoryMethodDesignPattern.AbstractFactory
{
    public abstract class PaymentGatewayFactory
    {
        public abstract IPaymentGateway CreatePaymentGateway();
    }
}
