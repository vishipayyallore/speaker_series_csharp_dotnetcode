using FirstWebApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly EmployeesDbContext _employeesDbContext;

        public EmployeesController(IConfiguration configuration)
        {
            var _configuration = configuration;

            var optionsBuilder = new DbContextOptionsBuilder<EmployeesDbContext>();

            var connectionString = _configuration["ConnectionStrings:EmployeesDBConnectionString"];
            optionsBuilder.UseSqlServer(connectionString);

            _employeesDbContext = new EmployeesDbContext(optionsBuilder.Options);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return _employeesDbContext.Employee.ToList();
        }


        [HttpGet("{id}")]
        public Employee GetEmployee(Guid id)
        {
            return _employeesDbContext.Employee.Where(record => record.Id == id).FirstOrDefault();
        }


        [HttpPost]
        public ActionResult<IEnumerable<Employee>> AddEmployee([FromBody] Employee employee)
        {
            employee = new Employee()
            {
                Name = "Rajesh Agarwal",
                Gender = "Male",
                Salary = 1234.89M
            };


            _employeesDbContext.Employee.Add(employee);

            _employeesDbContext.SaveChanges();

            return Created("", employee);
        }

        [HttpPut]
        public ActionResult<IEnumerable<Employee>> UpdateEmployee([FromBody] Employee employee)
        {


            var employee1 = _employeesDbContext.Employee.Where(record => record.Id == employee.Id).FirstOrDefault();

            employee1.Salary = employee.Salary;

            _employeesDbContext.SaveChanges();

            return NoContent();
        }

    }

}