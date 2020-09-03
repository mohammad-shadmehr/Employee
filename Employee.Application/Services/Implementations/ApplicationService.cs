using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Application.Interfaces;
using Employee.Domain.Models;
using Employee.Infrastructure.Interfaces;
using Employee.Application.DTOs;

namespace Employee.Application.Implementations
{
    public class ApplicationService : IApplicationService
    {
        private readonly IRepository<Domain.Models.Employee> _employeeRepository;

        public ApplicationService(
            IEmployeeRepository employeeRepository
            )
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetListOfEmployeeAsync()
        {
            var employees = await _employeeRepository.SelectAllAsync();

            var result = employees.Select(p => new EmployeeDto { 
                                                        Email = p.Email, 
                                                        FirstName = p.FirstName, 
                                                        LastName = p.LastName, 
                                                        Gender = p.Gender, 
                                                        Id = p.Id, 
                                                        Status = p.Status 
                                            });
            return result;
        }
    }
}
