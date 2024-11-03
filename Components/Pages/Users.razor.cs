using Microsoft.AspNetCore.Components;
namespace BlazorLabb.Components.Pages
{
	public partial class Users
	{
		private List<User>? _users;


		private FakeUserData _fakeUserData = new FakeUserData();
		private JsonUserData _jsonUserData = new JsonUserData();
		
		private IUserDataAccess _dataAccess { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await Task.Delay(500);
			_dataAccess = _fakeUserData;
			DisplaySome();
		}

		private async void SwitchToJsonUsers()
		{
			_dataAccess = _jsonUserData;
			await _jsonUserData.LoadUsersFromJson();
			DisplaySome();
		}

		private void DisplaySome()
		{
			_users = _dataAccess.Users.GetFilteredUsers(0, 5);
		}

		private void SortById()
		{
			_users = _dataAccess.Users.SortByID();
		}

		private void SortByName()
		{
			_users = _dataAccess.Users.SortByName();
		}


	}
}
