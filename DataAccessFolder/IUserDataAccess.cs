using BlazorLabb.UserClasses;

namespace BlazorLabb.DataFolder
{
    public interface IUserDataAccess
    {
        List<User> GetUsers { get; }
    }
}
