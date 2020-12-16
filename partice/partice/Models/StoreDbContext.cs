using Microsoft.EntityFrameworkCore;

namespace partice.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
           : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
