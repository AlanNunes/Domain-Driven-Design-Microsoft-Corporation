using Microsoft.EntityFrameworkCore;
using SharedKernel.Domain.Aggregates;
using SharedKernel.Infra.Data.Configs;

namespace SharedKernel.Infra.Data.Context
{
    public class MicrosoftCorporationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MicrosoftCorporationContext(DbContextOptions<MicrosoftCorporationContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
