// INJECTOR OBJECT

using DependencyInjectionDesignPattern.BLL;
using DependencyInjectionDesignPattern.DAL;

var customerDataManager = new CustomerDataManager();

// using Constructor
//var customerService = new CustomerService(customerDataManager);

// using Property
var customerService = new CustomerService();
//customerService.CustomerDataManager = customerDataManager;

// using Method
var customer = customerService.GetCustomerById("1", customerDataManager);
if (customer == null)
{
    Console.WriteLine("No customer found");
    return;
}

Console.WriteLine($"Customer Name: {customer.CustomerName}");
Console.ReadLine();