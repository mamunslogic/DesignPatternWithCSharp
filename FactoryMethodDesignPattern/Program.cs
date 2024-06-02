//Assume you’re building an e-commerce application and want to support multiple payment methods,
//like Credit Card, PayPal, and Bitcoin. Using the Factory Method pattern,
//you can instantiate the appropriate payment gateway based on the user’s choice.
//Let us see how we can implement the above example using the Factory Method Design Pattern in C#:




//Abstract Product: This is the interface or abstract class defining the product the factory method will create.
//Concrete Product: These are the specific implementations of the Product interface or abstract class.
//Abstract Factory or Creator: This abstract class or interface declares the FactoryMethod().
//Concrete Factory or Creator: Subclasses of Creator that implement the FactoryMethod() to produce ConcreteProduct instances.


using FactoryMethodDesignPattern;
using FactoryMethodDesignPattern.ConcreteFactory;

var ecommercePlatform = new ECommercePlatform();
ecommercePlatform.Checkout(new CreditCardPaymentGatewayFactory(), 100);

var paymentGateway = new PaypalPaymentGatewayFactory().CreatePaymentGateway();
paymentGateway.ProcessPayment(200);

paymentGateway = new BitcoinPaymentGatewayFactory().CreatePaymentGateway();
paymentGateway.ProcessPayment(300);