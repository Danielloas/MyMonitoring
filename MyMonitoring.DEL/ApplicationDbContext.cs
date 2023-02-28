using Microsoft.EntityFrameworkCore;
using MyMonitoring.Domain.Entity;

namespace MyMonitoring.DEL
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
        }
        public DbSet<Car> Car { get; set; }
    }
}