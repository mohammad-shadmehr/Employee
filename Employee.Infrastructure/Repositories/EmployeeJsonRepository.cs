using System.Collections.Generic;
using System.Threading.Tasks;
using Employee.Domain.Models;
using Employee.Infrastructure.Interfaces;
using Employee.Infrastructure.Helpers;

namespace Employee.Infrastructure.Repositories
{
    public class EmployeeJsonRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<Domain.Models.Employee>> SelectAllAsync()
        {
            var path = "MOCK_DATA.json";
            var data = FileHelper.Read(FileHelper.PersistancePath + path);
            var result = JsonHelper.Deserialise<IEnumerable<Domain.Models.Employee>>(data);

            return result;
        }
    }
}
