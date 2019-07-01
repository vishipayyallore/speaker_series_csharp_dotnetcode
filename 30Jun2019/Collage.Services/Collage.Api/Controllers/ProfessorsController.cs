using Collage.Api.Entities;
using Collage.Api.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Collage.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        private readonly CollegeDbContext _collegeDbContext;

        public ProfessorsController(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Professor>> GetAllProfessors()
        {
            var professors = _collegeDbContext.Professors
                .Include(student => student.Students)
                .ToList();

            return Ok(professors);
        }

    }

}