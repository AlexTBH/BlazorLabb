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

		
	}
}
