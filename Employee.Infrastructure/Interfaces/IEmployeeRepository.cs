using Employee.Domain.Models;

namespace Employee.Infrastructure.Interfaces
{
    public interface IEmployeeRepository : IRepository<Domain.Models.Employee>
    {
    }
}