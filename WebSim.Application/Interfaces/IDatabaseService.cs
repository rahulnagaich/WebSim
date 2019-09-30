using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WebSim.Domain.ApplicationRoles;
using WebSim.Domain.ApplicationUsers;
using WebSim.Domain.Users;

namespace WebSim.Application.Interfaces
{
    public interface IDatabaseService
    {
        string CurrentUserId { get; set; }

       // DbSet<User> Users { get; set; }

        int Save();

        int SaveChanges();

        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
    }
}