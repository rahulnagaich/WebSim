using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSim.Domain.Customers;

namespace WebSim.Persistence.Customers
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

            builder.HasIndex(c => c.Name);

            builder.Property(c => c.Email).HasMaxLength(100);

            builder.Property(c => c.PhoneNumber).IsUnicode(false).HasMaxLength(30);

            builder.Property(c => c.City).HasMaxLength(50);

            builder.ToTable("Customers");
        }
    }
}