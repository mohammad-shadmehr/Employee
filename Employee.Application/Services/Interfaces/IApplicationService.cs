using System.Collections.Generic;
using System.Threading.Tasks;
using Employee.Application.DTOs;

namespace Employee.Application.Interfaces
{
    public interface IApplicationService
    {
        Task<IEnumerable<EmployeeDto>> GetListOfEmployeeAsync();
    }
}
