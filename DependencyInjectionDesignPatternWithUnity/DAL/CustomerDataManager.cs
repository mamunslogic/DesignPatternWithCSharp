// SERVICE OR DEPENDENCY OR INDEPENDENT OBJECT

using DependencyInjectionDesignPatternWithUnity.DAL;
using DependencyInjectionDesignPatternWithUnity.Models;

namespace DependencyInjectionDesignPattern.DAL
{
    public class CustomerDataManager : ICustomerDataManager
    {
        public List<Customer> GetCustomers()
        {
            var customerList = new List<Customer>
            {
                new Customer{CustomerId = 1, Name = "Abul Kalam", Email="abul_kamal@gmail.com"},
                new Customer{CustomerId = 1, Name = "Zamal Udding", Email="zamal_uddin@gmail.com"}
            };
            return customerList;
        }
    }
}
