using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> SelectAllAsync();
    }
}
