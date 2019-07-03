using College.Common.Dtos;
using College.Common.Entities;
using College.Common.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace College.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        readonly IProfessorsBusiness _professorsBusiness;

        public ProfessorsController(IProfessorsBusiness professorsBusiness)
        {
            _professorsBusiness = professorsBusiness;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Professor>> Get()
        {
            var professors = _professorsBusiness.GetProfessors();

            return Ok(professors);
        }

        [HttpGet("{id}")]
        public ActionResult<Professor> GetProfessorById(Guid id)
        {
            var professor = _professorsBusiness.GetProfessorById(id);

            if (professor == null)
            {
                return NotFound();
            }

            return Ok(professor);
        }

        [HttpPost]
        public ActionResult<Professor> AddProfessor([FromBody]ProfessorForAddOrUpdate professorForAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var professor = new Professor
            {
                Name = professorForAdd.Name,
                Doj = professorForAdd.Doj,
                Salary = professorForAdd.Salary,
                IsPhd = professorForAdd.IsPhd,
                Teaches = professorForAdd.Teaches
            };

            var createdProfessor = _professorsBusiness.AddProfessor(professor);

            return Created(string.Empty, createdProfessor);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProfessor(Guid id, [FromBody]Professor professor)
        {
            var _ = _professorsBusiness.UpdateProfessor(id, professor);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProfessor(Guid id)
        {
            var professorDeleted = _professorsBusiness.DeleteProfessorById(id);

            if (!professorDeleted)
            {
                return StatusCode(500, $"Unable to delete Professor with id {id}");
            }

            return NoContent();
        }

    }

}