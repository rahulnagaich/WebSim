using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSim.Domain.Orders;

namespace WebSim.Persistence.Orders
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        private const string priceDecimalType = "decimal(18,2)";

        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.Property(p => p.UnitPrice).HasColumnType(priceDecimalType);

            builder.Property(p => p.Discount).HasColumnType(priceDecimalType);
        }
    }
}