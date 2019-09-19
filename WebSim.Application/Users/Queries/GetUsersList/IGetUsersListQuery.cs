namespace WebSim.Application.Users.Queries.GetUsersList
{
    public interface IGetUsersListQuery
    {
        UserListItemModel Execute(int pageNumber, int pageSize, string searchString, string sortOrder);
    }
}