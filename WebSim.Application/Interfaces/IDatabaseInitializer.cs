using System.Threading.Tasks;

namespace WebSim.Application.Interfaces
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}