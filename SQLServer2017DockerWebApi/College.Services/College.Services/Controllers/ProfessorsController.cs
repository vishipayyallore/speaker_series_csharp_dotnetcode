using College.Services.BAL;
using College.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace College.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        readonly ProfessorsBal _professorsBusiness;

        public ProfessorsController(IConfiguration configuration)
        {
            _professorsBusiness = new ProfessorsBal(configuration);
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
        public ActionResult<Professor> AddProfessor([FromBody]Professor professor)
        {
            var createdProfessor = _professorsBusiness.AddProfessor(professor);

            return Created(string.Empty, createdProfessor);
        }

        [HttpPut]
        public ActionResult UpdateProfessor([FromBody]Professor professor)
        {
            var _ = _professorsBusiness.UpdateProfessor(professor);

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