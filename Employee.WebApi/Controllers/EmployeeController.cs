using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee.Application.DTOs;
using Employee.Application.Interfaces;

namespace Employee.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IApplicationService _employeeService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IApplicationService parkingService)
        {
            _logger = logger;
            _employeeService = parkingService;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<EmployeeDto> GetAll()
        {
            try
            {
                var response = _employeeService.GetListOfEmployeeAsync().Result;

                return response.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
