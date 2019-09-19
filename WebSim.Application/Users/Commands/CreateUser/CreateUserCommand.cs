using System;
using WebSim.Application.Interfaces;
using WebSim.Application.Users.Commands.CreateUser.Factory;
using WebSim.Common.Dates;
using WebSim.Common.PasswordGenerator;
using WebSim.Common.Security;

namespace WebSim.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IDateService _dateService;
        private readonly ICreateUserFactory _factory;
        private readonly IPasswordGenerator _passwordGenerator;
        private readonly ISecurityService _securityService;

        public CreateUserCommand(IDatabaseService databaseService, IDateService dateService, ICreateUserFactory factory, IPasswordGenerator passwordGenerator, ISecurityService securityService)
        {
            _databaseService = databaseService;
            _dateService = dateService;
            _factory = factory;
            _passwordGenerator = passwordGenerator;
            _securityService = securityService;
        }

        public void Execute(CreateUserModel model, Guid createdBy)
        {
            var email = model.Email.Trim();
            var firstname = model.FirstName.Trim();
            var lastname = model.LastName.Trim();
            var resetPassword = model.ResetPassword;
            var createdOn = _dateService.GetDate();
            string userPassword = string.Empty;

            userPassword = model.RandomPassword == true ? _passwordGenerator.GetPassword() : model.Password;

            string securityStamp = _securityService.CreateSecurityStamp(32);

            var passwordHash = _securityService.CreatePasswordHash(userPassword, securityStamp);

            var user = _factory.Create(email, firstname, lastname, resetPassword, securityStamp, passwordHash, createdBy, createdOn);

            _databaseService.Users.Add(user);

            //if (model.Roles.Count > 0 && model.Roles != null)
            //{
            //    var roles = _databaseService.Roles.Where(x => model.Roles.Contains(x.Id) && x.Active == true && x.IsDeleted == false).ToList();

            //    foreach (var role in roles)
            //    {
            //        var userRole = _userRoleFactory.Create(user, role);

            //        _databaseService.UserRoles.Add(userRole);
            //    }
            //}

            _databaseService.Save();

            //if (model.RandomPassword)
            //{
            //    var emailSubject = _subjectService.UserPasswordSubject();

            //    var emailBody = "<br /><h1 style='color:#E0E0E0;'>Your Password is: " + userPassword + "</h1><br /><br />";

            //    var bccEmails = _bccEmailService.CreateUser();

            //    _emailService.SendEmail(emailSubject, emailBody, email, bccEmails);
            //}
        }
    }
}