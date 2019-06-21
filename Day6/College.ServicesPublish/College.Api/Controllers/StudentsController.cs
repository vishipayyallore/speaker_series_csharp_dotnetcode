using College.Comman.Interface;
using College.Data.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace College.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        readonly CollegeDbContext _collegeDbContext;
        readonly IStudentsBusiness _studentsBusiness;

        public StudentsController(CollegeDbContext collegeDbContext, IStudentsBusiness studentsBusiness)
        {
            _collegeDbContext = collegeDbContext;
            _studentsBusiness = studentsBusiness;
        }


        [HttpGet]
        public ActionResult Get()
        {
            var students = _collegeDbContext.Students.ToList();

            return Ok(students);
        }

        [HttpGet("sayHello")]
        public ActionResult Get(string sayHello)
        {
            return Ok(_studentsBusiness.SayHello());
        }
    }
}