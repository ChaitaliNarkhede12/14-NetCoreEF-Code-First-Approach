using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreCodeFirstApproach.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeDbContext employeeDbContext = null;

        public EmployeeController(EmployeeDbContext _employeeDbContext)
        {
            this.employeeDbContext = _employeeDbContext;
        }
        public IActionResult GetEmployeeList()
        {
            var result = this.employeeDbContext.Employees.ToList();
            return Ok(result);
        }
    }
}
