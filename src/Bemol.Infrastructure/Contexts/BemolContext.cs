using Bemol.Domain.Entities;
using Bemol.Infrastructure.Configurations;
using Bemol.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Bemol.Infrastructure.Contexts
{
    public class BemolContext : DbContext
    {
        public BemolContext(DbContextOptions<BemolContext> dbContextOptions) : base(dbContextOptions)
        {
            if (dbContextOptions is null)
            { throw new ArgumentNullException(nameof(dbContextOptions)); }
        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Bemol");
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.Seed();
        }
    }
}
