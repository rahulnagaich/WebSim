using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSim.Application.Users.Commands.CreateUser
{
    public class CreateUserModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be {2} characters long.", MinimumLength = 1)]
        [RegularExpression(@"(^[a-zA-Z]+[a-zA-Z0-9-_]*$)", ErrorMessage = "First name must start with an alphabet, only _ and - is allowed")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "The {0} must be {2} characters long.", MinimumLength = 1)]
        [RegularExpression(@"(^[a-zA-Z]+[a-zA-Z0-9-_]*$)", ErrorMessage = "Last name must start with an alphabet, only _ and - is allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        public string Email { get; set; }

        public List<Guid> Roles { get; set; }

        public bool RandomPassword { get; set; }

        public bool ResetPassword { get; set; }

        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 0)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$", ErrorMessage = "Password must contain one uppercase, one lowercase, one number and one special character.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}