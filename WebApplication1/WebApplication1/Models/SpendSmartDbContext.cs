using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models

{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expenses> Expenses { get; set; }
        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) : base(options) { 
            
        }
    }
}
