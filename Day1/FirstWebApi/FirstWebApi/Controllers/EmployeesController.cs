using FirstWebApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public EmployeesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeesDbContext>();

            var connectionString = _configuration["ConnectionStrings:EmployeesDBConnectionString"];
            optionsBuilder.UseSqlServer(connectionString);

            EmployeesDbContext employeesDbContext = new EmployeesDbContext(optionsBuilder.Options);

            return employeesDbContext.Employee.ToList();
        }

    }

}