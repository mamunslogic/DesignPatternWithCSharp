using RepositoryDesignPattern.DAL;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDesignPattern.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeesByDepartment(string department)
        {
            return _dataSet.Where(s => s.Dept.Equals(department)).ToList();
        }

        public IEnumerable<Employee> GetEmployeesByGender(string gender)
        {
            return _dataSet.Where(s => s.Gender.Equals(gender)).ToList();
        }
    }
}