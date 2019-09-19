using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSim.Domain.Users;

namespace WebSim.Persistence.Users
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(q => q.Email)
                .HasMaxLength(256)
                .IsRequired();

            builder.HasIndex(q => q.Email)
                    .IsUnique();

            builder.Property(q => q.PasswordHash)
                .HasMaxLength(4000);

            builder.Property(q => q.SecurityStamp)
                .HasMaxLength(4000);

            builder.Property(q => q.FirstName)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(q => q.LastName)
                .HasMaxLength(50);

            builder.Property(q => q.EmailConfirmed)
                .IsRequired();

            builder.Property(q => q.LockoutEndDateUtc);

            builder.Property(q => q.LockoutEnabled)
                .IsRequired();

            builder.Property(q => q.AccessFailedCount)
                .IsRequired();

            builder.Property(q => q.IsStatic)
                .IsRequired();

            builder.Property(q => q.ResetPassword)
               .IsRequired();

            builder.Property(q => q.CreatedBy)
                .IsRequired();

            builder.Property(q => q.CreatedOn)
                .IsRequired();

            builder.Property(q => q.LastModifiedBy);

            builder.Property(q => q.LastModifiedOn);

            builder.Property(q => q.IsDeleted)
               .IsRequired();

            builder.Property(q => q.DeletedBy);

            builder.Property(q => q.DeletedOn);
        }
    }
}