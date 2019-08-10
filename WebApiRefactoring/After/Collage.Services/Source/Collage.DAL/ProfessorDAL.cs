using Collage.Common.Entities;
using Collage.Common.Interfaces;
using Collage.DAL.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Collage.DAL
{
    public class ProfessorDAL : IProfessorDAL
    {
        private readonly CollegeDbContext _collegeDbContext;

        public ProfessorDAL(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _collegeDbContext
                        .Professors
                        .Include(row => row.Students)
                        .ToList();
        }
    }
}
