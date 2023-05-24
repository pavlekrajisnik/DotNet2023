
using VirtualDj.Models;

namespace VirtualDj.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        {
            
        }

        public DbSet<Pjesma> Pjesme => Set<Pjesma>();
    }
}
