using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSim.Domain.Orders;

namespace WebSim.Persistence.Orders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        const string priceDecimalType = "decimal(18,2)";

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Comments).HasMaxLength(500);

            builder.ToTable("Orders");

            builder.Property(p => p.Discount).HasColumnType(priceDecimalType);
        }
    }
}