using DependencyInjectionDesignPatternInWebProject.BLL;
using DependencyInjectionDesignPatternWithUnity.DAL;
using DependencyInjectionDesignPatternWithUnity.Models;

namespace DependencyInjectionDesignPatternWithUnity.BLL
{
    public class CustomerService : ICustomerService
    {
        private ICustomerDataManager _customerDataManager;

        public CustomerService(ICustomerDataManager customerDataManager)
        {
            _customerDataManager = customerDataManager;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerDataManager.GetCustomers();
        }
    }
}
