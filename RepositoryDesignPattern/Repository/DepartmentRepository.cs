using RepositoryDesignPattern.DAL;

namespace RepositoryDesignPattern.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
    }
}