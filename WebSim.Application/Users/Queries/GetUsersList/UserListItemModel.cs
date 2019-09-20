using System;
using System.Collections.Generic;

namespace WebSim.Application.Users.Queries.GetUsersList
{
    public class UserListItemModel
    {
        public List<UserListItem> List { get; set; }

        public int TotalCount { get; set; }
    }

    public class UserListItem
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool IsStatic { get; set; }

        public  DateTime CreatedOn { get; set; }
    }
}