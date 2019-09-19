using System;
using WebSim.Domain.Common;

namespace WebSim.Domain.Users
{
    public class User : IEntity, ICreateEntity, IUpdateEntity, IDeleteEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public bool IsStatic { get; set; }

        public bool ResetPassword { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}