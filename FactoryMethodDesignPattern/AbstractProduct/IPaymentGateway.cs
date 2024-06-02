namespace FactoryMethodDesignPattern.AbstractProduct
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
