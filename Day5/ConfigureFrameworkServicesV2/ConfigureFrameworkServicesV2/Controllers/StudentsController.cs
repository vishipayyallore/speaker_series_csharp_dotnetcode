using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigureFrameworkServicesV2.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConfigureFrameworkServicesV2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<object>> Get()
        {
            var students = new List<object>
            {
                new { Id = 101, Name = "Shiva Sai"},
                new { Id = 102, Name = "Mathew Philips"},
                new { Id = 103, Name = "Mohd Hafeez"}
            };

            return students;
        }

        [HttpGet("{id}")]
        public ActionResult<object> Get(int id, [FromQuery]int version, [FromQuery]string format)
        {
            var student = new { Id = 101, Name = "Shiva Sai"};

            var age = Request.GetHeaderValue("age");



            return student;
        }

    }

}