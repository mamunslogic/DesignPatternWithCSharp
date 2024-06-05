using DependencyInjectionDesignPatternWithUnity.Models;

namespace DependencyInjectionDesignPatternInWebProject.BLL
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
    }
}
