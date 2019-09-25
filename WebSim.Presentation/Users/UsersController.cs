﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebSim.Application.Users.Commands.CreateUser;
using WebSim.Application.Users.Queries.GetUsersList;

namespace WebSim.Presentation.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICreateUserCommand _createUserCommand;
        private readonly IGetUsersListQuery _usersListQuery;

        public UsersController(
            ICreateUserCommand createUserCommand,
            IGetUsersListQuery usersListQuery
            )
        {
            _createUserCommand = createUserCommand;
            _usersListQuery = usersListQuery;
        }

        [Route("list")]
        [HttpGet]
        // [Authorize(Policy = "CanViewUser")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetUsers(int page = 1, int pageSize = 10, string search = "", string sortBy = "", string sortOrder = "desc")
        {
            var users = _usersListQuery.Execute(page, pageSize, search, sortBy, sortOrder);

            return Ok(users);
        }

        [Route("create")]
        [HttpGet]
        // [Authorize(Policy = "CanAddUser")]
        public IActionResult CreateUser()
        {
            //var roles = _getAllRolesQuery.Execute();

            //var json = new
            //{
            //    Roles = roles
            //};

            return Ok();
        }

        [HttpPost("create")]
        // [Authorize(Policy = "CanAddUser")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        public IActionResult CreateUser([FromBody]CreateUserModel model)
        {
            if (!model.RandomPassword)
            {
                if (string.IsNullOrEmpty(model.Password))
                {
                    ModelState.AddModelError("Password", "The password field is required.");
                }
                if (!string.IsNullOrEmpty(model.Password) && model.Password.Length < 8)
                {
                    ModelState.AddModelError("Password", "The password must be at least 8 characters long.");
                }
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (_verifyUser.Verify(model.Email.Trim()))
            //{
            //    return BadRequest(_messageService.Conflict().Replace("resource", "user email"));
            //}

            //var lastModifiedBy = _userService.GetUser(HttpContext);

            var lastModifiedBy = new Guid();

            _createUserCommand.Execute(model, lastModifiedBy);

            return StatusCode(StatusCodes.Status201Created, "Record Created");
        }
    }
}