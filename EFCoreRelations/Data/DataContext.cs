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
                "server=.\\sqlexpress;database=efcoretest;trusted_connection=true;");
            }
        }

        public DbSet<User>? Users { get; set; }
    }
}
