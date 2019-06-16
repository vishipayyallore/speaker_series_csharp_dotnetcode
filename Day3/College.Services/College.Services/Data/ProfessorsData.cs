using College.Services.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace College.Services.Data
{

    public class ProfessorsData
    {
        readonly CollegeDbContext _collegeDbContext;

        public ProfessorsData(IConfiguration configuration)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CollegeDbContext>();

            var connectionString = configuration["ConnectionStrings:CollegeDBConnectionString"];
            optionsBuilder.UseSqlServer(connectionString);

            _collegeDbContext = new CollegeDbContext(optionsBuilder.Options);
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _collegeDbContext.Professors.ToList();
        }


        public Professor GetProfessorById(Guid id)
        {
            if (!_collegeDbContext.Professors.Any(record => record.Id == id))
            {
                return null;
            }

            return _collegeDbContext.Professors.Where(record => record.Id == id).FirstOrDefault();
        }

        public Professor AddProfessor(Professor professor)
        {
            _collegeDbContext.Professors.Add(professor);

            _collegeDbContext.SaveChanges();

            return professor;
        }

    }

}
