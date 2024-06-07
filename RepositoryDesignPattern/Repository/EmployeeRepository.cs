using RepositoryDesignPattern.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryDesignPattern.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBDataContext _dbDataContext;

        public EmployeeRepository()
        {
            _dbDataContext = new EmployeeDBDataContext();
        }

        public EmployeeRepository(EmployeeDBDataContext dBDataContext)
        {
            _dbDataContext = dBDataContext;
        }

        public void Delete(int EmployeeID)
        {
            var employee = _dbDataContext.Employees.Find(EmployeeID);
            if(employee != null)
            _dbDataContext.Employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dbDataContext.Employees.ToList();
        }

        public Employee GetById(int EmployeeID)
        {
            return _dbDataContext.Employees.Find(EmployeeID);
        }

        public void Insert(Employee employee)
        {
            _dbDataContext.Employees.Add(employee);
        }

        public void Save()
        {
            _dbDataContext.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _dbDataContext.Entry(employee).State = EntityState.Modified;
        }
    }
}