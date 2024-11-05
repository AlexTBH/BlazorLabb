using Microsoft.AspNetCore.Components;
namespace BlazorLabb.Components.Pages
{
	public partial class Users
	{
		private List<User>? _users;


		
		public IUserDataAccess DataAccess { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await Task.Delay(500);
			DataAccess = new FakeUserData();
			DisplaySome();
		}

		private async Task SwitchToJsonUsers()
		{
			_users = null;
			DataAccess = new JsonUserData();
			await Task.Run(() => DisplaySome());
		}

		private void DisplaySome()
		{
			_users = DataAccess.Users.GetFilteredUsers(0, 10);
		}

		private void SortById()
		{
			_users = DataAccess.Users.SortByID();
		}

		private void SortByName()
		{
			_users = DataAccess.Users.SortByName();
		}


	}
}
