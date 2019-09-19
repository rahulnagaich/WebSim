using System;
using System.Text;
using WebSim.Domain.Users;

namespace WebSim.Common.Security
{
    public class SecurityService : ISecurityService
    {
        public string CreatePasswordHash(string password, string Salt)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(Salt))
            {
                throw new ArgumentNullException("Password or salt null");
            }

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password + Salt);

            System.Security.Cryptography.SHA256Managed sha256hashstring =
                new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sha256hashstring.ComputeHash(bytes);

            StringBuilder hex = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
                hex.AppendFormat("{0:x2}", b);

            return hex.ToString();
        }

        public string CreateSecurityStamp(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();

            var buff = new byte[size];

            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        public User SetPasswordHash(User user, string passwordHash)
        {
            if (user == null || string.IsNullOrWhiteSpace(passwordHash))
            {
                throw new ArgumentNullException("user or password null");
            }

            user.PasswordHash = passwordHash;

            return user;
        }

        public User SetSecurityStamp(User user, string stamp)
        {
            if (user == null || string.IsNullOrWhiteSpace(stamp))
            {
                throw new ArgumentNullException("user or securityStamp null");
            }

            user.SecurityStamp = stamp;

            return user;
        }
    }
}