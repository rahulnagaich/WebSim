using System;
using WebSim.Domain.Users;

namespace WebSim.Application.Users.Commands.CreateUser.Factory
{
    public class CreateUserFactory : ICreateUserFactory
    {
        public User Create(string email, string firstName, string lastName, bool resetPassword,
           string securityStampt, string passwordHash, Guid createdBy, DateTime createdOn)
        {
            var user = new User()
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                CreatedBy = createdBy,
                CreatedOn = createdOn,
                ResetPassword = resetPassword,
                SecurityStamp = securityStampt,
                PasswordHash = passwordHash
            };

            return user;
        }
    }
}