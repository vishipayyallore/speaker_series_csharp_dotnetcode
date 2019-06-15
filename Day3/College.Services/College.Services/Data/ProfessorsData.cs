using College.Services.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

    }

}
