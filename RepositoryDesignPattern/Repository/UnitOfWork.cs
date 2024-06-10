using RepositoryDesignPattern.DAL;
using System;
using System.Data;
using System.Data.Entity;

namespace RepositoryDesignPattern.Repository
{
    public class UnitOfWork : IDisposable
    {
        private EmployeeDBDataContext _context = new EmployeeDBDataContext();
        private bool _disposed = false;
        private DbContextTransaction _transaction = null;

        private EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_context); //new GenericRepository<Employee>(_context);
                }
                return _employeeRepository;
            }
        }

        private GenericRepository<Department> _departmentRepository;
        public GenericRepository<Department> DepartmentRepository
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new GenericRepository<Department>(_context);
                }
                return _departmentRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void CreateTransaction()
        {
            if (_transaction == null)
                _transaction = _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (_transaction != null)
                _transaction.Commit();
        }

        public void RolebackTransaction()
        {
            if (_transaction != null)
                _transaction.Rollback();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}