using System;
using WebSim.Domain.Users;

namespace WebSim.Application.Users.Commands.CreateUser.Factory
{
    public interface ICreateUserFactory
    {
        User Create(string email, string firstName, string lastName, bool resetPassword,
          string securityStampt, string passwordHash, Guid createdBy, DateTime createdOn);
    }
}