using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Domain.Aggregates;

namespace SharedKernel.Infra.Data.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.OwnsOne(p => p.Price)
                .Property(p => p.Amount).HasColumnName("Price");
            builder.OwnsOne(p => p.Price)
                .Property(p => p.Currency).HasColumnName("Currency");
        }
    }
}
