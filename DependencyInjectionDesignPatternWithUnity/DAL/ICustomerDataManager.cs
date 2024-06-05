using DependencyInjectionDesignPatternWithUnity.Models;

namespace DependencyInjectionDesignPatternWithUnity.DAL
{
    public interface ICustomerDataManager
    {
        List<Customer> GetCustomers();
    }
}
