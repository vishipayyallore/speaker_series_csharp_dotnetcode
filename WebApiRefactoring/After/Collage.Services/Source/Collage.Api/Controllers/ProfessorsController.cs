using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collage.Common.Entities;
using Collage.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Collage.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        private readonly IProfessorBLL _professorBLL;

        public ProfessorsController(IProfessorBLL professorBLL)
        {
            _professorBLL = professorBLL;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Professor>> Get()
        {
            var professors = _professorBLL.GetProfessors();

            return Ok(professors);
        }

    }


}