using Microsoft.EntityFrameworkCore;
using ProCleaner.Models;

namespace ProCleaner.Data
{
    public class ProCleanerContext : DbContext
    {
        public ProCleanerContext(DbContextOptions<ProCleanerContext> options)
            : base(options)
        {
        }

        public DbSet<Machine> Machine { get; set; } 
    }
}