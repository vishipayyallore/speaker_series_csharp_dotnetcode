using ADCEmployeesAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADCEmployeesAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        readonly EmployeesDbContext _employeesDbContext;

        public EmployeesController(IConfiguration configuration)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeesDbContext>();

            var connectionString = configuration["ConnectionStrings:EmployeesDBConnectionString"];
            optionsBuilder.UseSqlServer(connectionString);

            _employeesDbContext = new EmployeesDbContext(optionsBuilder.Options);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            var employees = _employeesDbContext.Employee.ToList();

            return Ok(employees);
        }


        [HttpGet("{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            if (!_employeesDbContext.Employee.Any(record => record.Id == id))
            {
                return NotFound();
            }

            var employee = _employeesDbContext.Employee.Where(record => record.Id == id).FirstOrDefault();

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            if(employee.Name == null)
            {
                return BadRequest();
            }

            _employeesDbContext.Employee.Add(employee);
            _employeesDbContext.SaveChanges();

            return Created("", employee);
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody]Employee employee)
        {
            if (!_employeesDbContext.Employee.Any(record => record.Id == employee.Id))
            {
                return NotFound();
            }

            if (employee.Salary <= 0)
            {
                return BadRequest();
            }

            var retrievedEmployee = _employeesDbContext.Employee.Where(record => record.Id == employee.Id).FirstOrDefault();
            retrievedEmployee.Salary = employee.Salary;

            _employeesDbContext.SaveChanges();

            return NoContent();
        }

    }


}