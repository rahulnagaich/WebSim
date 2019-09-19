using WebSim.Domain.Users;

namespace WebSim.Common.Security
{
    public interface ISecurityService
    {
        string CreatePasswordHash(string password, string Salt);

        User SetPasswordHash(User user, string passwordHash);

        string CreateSecurityStamp(int size);

        User SetSecurityStamp(User user, string stamp);
    }
}