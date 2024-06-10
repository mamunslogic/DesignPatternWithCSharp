using RepositoryDesignPattern.DAL;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDesignPattern.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBDataContext dbContext):base(dbContext)
        {
            
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(int departmentId)
        {
            return _dataSet.Where(s => s.DepartmentID.Equals(departmentId)).ToList();
        }

        public IEnumerable<Employee> GetEmployeesByGender(string gender)
        {
            return _dataSet.Where(s => s.Gender.Equals(gender)).ToList();
        }
    }
}