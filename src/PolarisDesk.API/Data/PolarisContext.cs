using Microsoft.EntityFrameworkCore;

namespace PolarisDesk.API.Data
{
    public class PolarisContext : DbContext
    {
        public PolarisContext(DbContextOptions<PolarisContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}