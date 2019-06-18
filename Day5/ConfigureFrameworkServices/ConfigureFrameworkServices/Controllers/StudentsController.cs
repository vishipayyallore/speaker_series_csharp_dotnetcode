using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConfigureFrameworkServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<object>> Get()
        {
            var students = new List<object>
            {
                new { Id = 101, Name = "Shiva Sai"},
                new { Id = 102, Name = "Mathew Philips"},
                new { Id = 103, Name = "Mohd Hafeez"}
            };

            return students;
        }

    }
}