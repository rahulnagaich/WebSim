using Microsoft.EntityFrameworkCore;
using WebSim.Domain.Users;

namespace WebSim.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<User> Users { get; set; }
    }
}