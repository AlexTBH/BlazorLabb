using BlazorLabb.UserClasses;

namespace BlazorLabb.DataFolder
{
    public class JsonUserData : IUserDataAccess
    {
        private List<User> _users = new List<User>();
        public List<User> GetUsers => _users;

        private readonly string jsonUrl = "https://jsonplaceholder.typicode.com/users";

        public async Task<List<User>> LoadUsersAsync()
        {
            try
            {
                if (!_users.Any())
                {
                    _users = await GetUsersFromJson(jsonUrl);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while loading users: {ex.Message}");
            }

            return _users;

        }

        private async Task<List<User>> GetUsersFromJson(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Error: JSON url path is null or empty");
                return new List<User>();
            }

            try
            {
                using (var client = new HttpClient())
                {
                    return await client.GetFromJsonAsync<List<User>>(path);
                }
            }
            catch (HttpRequestException e)
            {
               Console.WriteLine($"Error loading JSON data: {e.Message}"); 
            }
            return _users;
        }
    }
}
