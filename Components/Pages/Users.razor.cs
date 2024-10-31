using Microsoft.AspNetCore.Components;
namespace BlazorLabb.Components.Pages
{
	public partial class Users
	{
		private List<User>? _users;

		[Parameter]
		public IUserDataAccess DataAcess { get; set; }

		protected override async Task OnInitializedAsync()
		{
			await Task.Delay(500);
			DataAcess ??= new FakeUserData();
			DisplaySome();
		}

		private void DisplaySome()
		{
			_users = DataAcess.Users.GetFilteredUsers(0, 10);
		}
	}
}
