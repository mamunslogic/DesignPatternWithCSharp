// SERVICE OR DEPENDENCY OR INDEPENDENT OBJECT

namespace DependencyInjectionDesignPattern.DAL
{
    public class CustomerDataManager : ICustomerDataManager
    {
        public List<Customer> GetCustomers()
        {
            var customerList = new List<Customer>
            {
                new Customer{CustomerId = "1", CustomerName = "Abul Kalam", ContactNo="01712568954"},
                new Customer{CustomerId = "2", CustomerName = "Zamal Udding", ContactNo="01918562394"}
            };
            return customerList;
        }
    }
}
