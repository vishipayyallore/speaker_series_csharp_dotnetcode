using College.Services.Business;
using College.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace College.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        readonly ProfessorsBusiness _professorsBusiness;

        public ProfessorsController(IConfiguration configuration)
        {
            _professorsBusiness = new ProfessorsBusiness(configuration);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Professor>> Get()
        {
            var professors = _professorsBusiness.GetProfessors();

            return Ok(professors);
        }

    }

}