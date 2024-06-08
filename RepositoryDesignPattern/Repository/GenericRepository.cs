using RepositoryDesignPattern.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryDesignPattern.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EmployeeDBDataContext _dbDataContext;
        public DbSet<T> _dataSet = null;

        public GenericRepository()
        {
            _dbDataContext = new EmployeeDBDataContext();
            _dataSet = _dbDataContext.Set<T>();
        }

        public void Delete(int id)
        {
            var data = _dataSet.Find(id);
            if (data != null)
                _dataSet.Remove(data);
        }

        public IEnumerable<T> GetAll()
        {
            return _dataSet.ToList();
        }

        public T GetById(int id)
        {
            return _dataSet.Find(id);
        }

        public void Insert(T obj)
        {
            _dataSet.Add(obj);
        }

        public void Save()
        {
            _dbDataContext.SaveChanges();
        }

        public void Update(T obj)
        {
            _dbDataContext.Entry(obj).State = EntityState.Modified;
        }
    }
}