using FactoryMethodDesignPattern.AbstractFactory;
using FactoryMethodDesignPattern.AbstractProduct;
using FactoryMethodDesignPattern.ConcreteProduct;

namespace FactoryMethodDesignPattern.ConcreteFactory
{
    public class CreditCardPaymentGatewayFactory : PaymentGatewayFactory
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new CreditCardPaymentGateway();
        }
    }
}
