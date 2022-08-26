using Microsoft.EntityFrameworkCore;

namespace EFCoreRelations.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "Host=TimescaleDB;Port=5432;Database=valutecdb;Username=postgres;Password=pwd");
            }
        }

        public DbSet<User>? Users { get; set; }
    }
}
