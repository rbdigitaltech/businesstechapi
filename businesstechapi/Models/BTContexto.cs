using Microsoft.EntityFrameworkCore;

namespace businesstechapi.Models
{
    public class BTContexto : DbContext
    {
        public BTContexto(DbContextOptions<BTContexto> options) : base(options)
        {
        }
        public DbSet<Aportes> Aportes { get; set; }
    }
}
