using College.Services.Entities;
using Microsoft.EntityFrameworkCore;

namespace College.Services.Data
{

    public class CollegeDbContext : DbContext
    {

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {

        }

        public DbSet<Professor> Professors { get; set; }
    }

}
