using System.Linq;
using WebSim.Application.Interfaces;

namespace WebSim.Application.Users.Queries.GetUsersList
{
    public class GetUsersListQuery : IGetUsersListQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetUsersListQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public UserListItemModel Execute(int pageNumber, int pageSize, string searchString, string sortBy, string sortOrder)
        {
           // int totalCount = 0;

            //var users = _databaseService.Users
            //    .Where(u => u.IsDeleted == false)
            //    .Select(u => new UserListItem()
            //    {
            //        Id = u.Id.ToString(),
            //        FirstName = u.FirstName,
            //        LastName = u.LastName,
            //        Email = u.Email,
            //        IsStatic = u.IsStatic,
            //        CreatedOn = u.CreatedOn
            //    });

            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    users = users.Where(s => s.Email.Contains(searchString) || s.FirstName.Contains(searchString) || s.LastName.Contains(searchString));
            //}

            //totalCount = users.Count();

            //if (!string.IsNullOrEmpty(sortOrder) && !string.IsNullOrEmpty(sortBy))
            //{
            //    sortOrder += sortBy == "asc" ? "_asc" : "_desc";
            //}

            //switch (sortOrder)
            //{
            //    case "firstName_desc":
            //        users = users.OrderByDescending(s => s.FirstName);
            //        break;

            //    case "lastName_asc":
            //        users = users.OrderBy(s => s.LastName);
            //        break;

            //    case "lastName_desc":
            //        users = users.OrderByDescending(s => s.LastName);
            //        break;

            //    case "email_asc":
            //        users = users.OrderBy(s => s.Email);
            //        break;

            //    case "email_desc":
            //        users = users.OrderByDescending(s => s.Email);
            //        break;

            //    default:
            //        users = users.OrderByDescending(s => s.CreatedOn);
            //        break;
            //}

            //users = users.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            var listItemModel = new UserListItemModel()
            {
                //List = users.ToList(),
                //TotalCount = totalCount
            };

            return listItemModel;
        }
    }
}