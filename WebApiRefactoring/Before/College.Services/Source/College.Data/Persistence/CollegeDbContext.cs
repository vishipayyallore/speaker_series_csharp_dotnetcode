using College.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace College.DAL.Persistence
{

    public class CollegeDbContext : DbContext
    {

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {

        }

        public DbSet<Professor> Professors { get; set; }
    }

}
