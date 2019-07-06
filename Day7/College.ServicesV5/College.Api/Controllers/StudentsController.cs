using College.Common.Entities;
using College.Common.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace College.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        readonly IStudentsBusiness _studentsBusiness;

        public StudentsController(IStudentsBusiness studentsBusiness)
        {
            _studentsBusiness = studentsBusiness;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = _studentsBusiness.GetAllStudents();

            return Ok(students);
        }

    }

}