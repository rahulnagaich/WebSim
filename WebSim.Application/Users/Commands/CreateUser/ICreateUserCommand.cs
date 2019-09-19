using System;

namespace WebSim.Application.Users.Commands.CreateUser
{
    public interface ICreateUserCommand
    {
        void Execute(CreateUserModel model, Guid createdBy);
    }
}