using FactoryMethodDesignPattern.AbstractFactory;
using FactoryMethodDesignPattern.AbstractProduct;
using FactoryMethodDesignPattern.ConcreteProduct;

namespace FactoryMethodDesignPattern.ConcreteFactory
{
    internal class PaypalPaymentGatewayFactory : PaymentGatewayFactory
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new PaypalPaymentGateway();
        }
    }
}
