using Microsoft.EntityFrameworkCore;

namespace EFCoreRelations.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }
    }
}
