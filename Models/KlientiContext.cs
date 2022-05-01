using Microsoft.EntityFrameworkCore;

namespace CrudTest2.Models
{
    public class KlientiContext:DbContext
    {
        public KlientiContext(DbContextOptions<KlientiContext> options) : base(options)
        {

        }
        public DbSet<KlientiDatabase> Klienti { get; set; }
    }
}
