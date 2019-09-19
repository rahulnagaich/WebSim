using Microsoft.EntityFrameworkCore;
using WebSim.Application.Interfaces;
using WebSim.Domain.Users;
using WebSim.Persistence.Users;

namespace WebSim.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
        }

        public int Save()
        {
            return SaveChanges();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}