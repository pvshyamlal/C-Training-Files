using Microsoft.EntityFrameworkCore;

namespace BackEndDb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // creting table properties below
        public DbSet<Model.Entities.Employee> Employees { get; set; }

    }
}
