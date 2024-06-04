// CLIENT OR DEPENDENT OBJECT

using DependencyInjectionDesignPattern.DAL;

namespace DependencyInjectionDesignPattern.BLL
{
    public class CustomerService
    {
        // Using Constructor
        //private readonly ICustomerDataManager _customerDataManager;

        //public CustomerService(ICustomerDataManager customerDataManager)
        //{
        //    _customerDataManager = customerDataManager;
        //}


        // Using Property
        //private ICustomerDataManager _customerDataManager;
        //public ICustomerDataManager CustomerDataManager
        //{
        //    set
        //    {
        //        _customerDataManager = value;
        //    }
        //}

        public Customer? GetCustomerById(string customerId, ICustomerDataManager _customerDataManager)
        {
            var customerList = _customerDataManager.GetCustomers();
            return customerList.SingleOrDefault(s => s.CustomerId == customerId);
        }
    }
}
