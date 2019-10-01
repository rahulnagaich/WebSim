using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using WebSim.Persistence;

namespace WebSim.Presentation
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseService>
    {
        public DatabaseService CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<DatabaseService>();

            builder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"], b => b.MigrationsAssembly("WebSim.Persistence"));

            return new DatabaseService(builder.Options);
        }
    }
}