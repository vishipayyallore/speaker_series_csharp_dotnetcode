using College.Comman.Entities;
using Microsoft.EntityFrameworkCore;

namespace College.Data.Persistence
{

    public class CollegeDbContext : DbContext
    {

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {

        }

        public DbSet<Professor> Professors { get; set; }
    }

}
