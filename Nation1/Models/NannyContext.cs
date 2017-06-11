using System.Data.Entity;

namespace Nation1.Models
{
    public class NannyContext : DbContext
    {
        public NannyContext() : base("Nation1")
        {
        }
        public DbSet<Nanny> Nannies { get; set; }
    }
}