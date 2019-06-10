using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.Entities
{

    public class EmployeesDbContext : DbContext
    {

        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }

}
