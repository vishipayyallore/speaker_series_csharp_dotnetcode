using College.Common.Entities;
using College.Common.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("{id}")]
        public ActionResult<Professor> GetStudentId(Guid id)
        {
            var student = _studentsBusiness.GetStudentById(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Professor> AddProfessor([FromBody]ProfessorForAddOrUpdate professorForAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var createdProfessor = _professorsBusiness.AddProfessor(professorForAdd);

            return Created(string.Empty, createdProfessor);
        }
    }

}