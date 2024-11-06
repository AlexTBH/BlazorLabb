using BlazorLabb.DataAccessFolder;
using BlazorLabb.DataFolder;
using BlazorLabb.UserClasses;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
namespace BlazorLabb.Components.Pages
{
    public partial class Users
	{
		private List<User>? _users;
		private string _searchInput;
		private IUserDataAccess _fakeUserData = new FakeUserData();
		private IUserDataAccess _jsonUserData = new JsonUserData();
		private bool _displayJsonUsers = false; 
		
		public IUserDataAccess DataAccess { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await Task.Delay(500);
			await ((JsonUserData)_jsonUserData).LoadUsersAsync();
			DataAccess = _fakeUserData;
			DisplaySome();
		}
		private async Task SwitchUserSource()
		{
			_users = null;

			if (_displayJsonUsers)
			{
				DataAccess = _fakeUserData;
				_displayJsonUsers = false;
			}
			else
			{
				DataAccess = _jsonUserData;
				_displayJsonUsers = true;
			}
			DisplaySome();
		}
		private void DisplaySome()
		{
			_users = DataAccess.GetUsers.GetFilteredUsers(0, 5).SortByName();
		}
		private void ShowAll()
		{
			_users = DataAccess.GetUsers.GetAllUsers();
		}
		private void SortById()
		{
			_users = DataAccess.GetUsers.SortByID();
		}
		private void SortByName()
		{
			_users = DataAccess.GetUsers.SortByName();
		}
		private void SearchString()
		{
			_users = DataAccess.GetUsers.SearchString(_searchInput);
		}
	}
}
