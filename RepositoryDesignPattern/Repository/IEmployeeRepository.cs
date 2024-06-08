using RepositoryDesignPattern.DAL;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Repository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesByGender(string gender);
        IEnumerable<Employee> GetEmployeesByDepartment(string department);
    }
}
