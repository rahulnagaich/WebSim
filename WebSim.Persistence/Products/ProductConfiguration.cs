using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSim.Domain.Products;

namespace WebSim.Persistence.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        const string priceDecimalType = "decimal(18,2)";

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.HasIndex(p => p.Name);

            builder.Property(p => p.Description).HasMaxLength(500);

            builder.Property(p => p.Icon).IsUnicode(false).HasMaxLength(256);

            builder.HasOne(p => p.Parent).WithMany(p => p.Children).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Products");

            builder.Property(p => p.BuyingPrice).HasColumnType(priceDecimalType);

            builder.Property(p => p.SellingPrice).HasColumnType(priceDecimalType);
        }
    }
}