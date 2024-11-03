namespace BlazorLabb
{
	public class JsonUserData : IUserDataAccess
	{
		private List<User> _users;
		public List<User> Users
		{
			get
			{
				return _users;
			}

		}

		private readonly string jsonUrl = "https://jsonplaceholder.typicode.com/users";
		
		public async Task<List<User>> LoadUsersFromJson()
		{

			if (_users == null || _users.Count == 0)
			{
				_users = await GetUsersFromJson(jsonUrl);
			}

			return _users;
		}

		private async Task<List<User>> GetUsersFromJson(string path)
		{

			using (var client = new HttpClient())
			{
				return await client.GetFromJsonAsync<List<User>>(path);
			}
		} 
	}
}
