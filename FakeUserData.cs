namespace BlazorLabb
{
	public class FakeUserData : IUserDataAccess
	{
		private List<User>? _users;

		public List<User> Users
		{
			get
			{
				if (_users == null)
				{
					_users = GetFakeUserData();
				}
				return _users;
			}
		}

		private List<User>? GetFakeUserData()
		{
			return new List<User>
			{
				new User { Id = 1, Name = "Alex", Email = "Alex@hotmail.com", Address = new Address { Street = "Huddingevägen 1", City = "Stockholm", Zipcode = "12345"}, Company = new Company { Name = "Botkyrka kommun", CatchPhrase = "Långt ifrån lagom"} },
				new User { Id = 2, Name = "Kalle", Email = "Kalle@hotmail.com", Address = new Address { Street = "Stockholmsvägen 2", City = "Stockholm", Zipcode = "54321"}, Company = new Company { Name = "Kalles kaviar", CatchPhrase = "Helt okej kaviar"} },
				new User { Id = 3, Name = "Eminem", Email = "Eminem@gmail.com", Address = new Address { Street = "8 mile", City = "Detroit", Zipcode = "313 12"}, Company = new Company { Name = "Self employed", CatchPhrase = "Moms spaghetti"} },
				new User { Id = 4, Name = "Glenn", Email = "Glenn@yahoo.com", Address = new Address { Street = "Göteborgsvägen", City = "Göteborg", Zipcode = "414 12"}, Company = new Company { Name = "Göteborgs kex", CatchPhrase = "Kex är gott"} },
				new User { Id = 5, Name = "Kjell", Email = "Kjelle@yahoo.com", Address = new Address { Street = "Kjellgatan", City = "Stockholm", Zipcode = "123 77"}, Company = new Company { Name = "Kjell & Co", CatchPhrase = "Teknik från hjärtat"} },
				new User { Id = 6, Name = "McNulty", Email = "McNulty@police.com", Address = new Address { Street = "Baltimore street", City = "Baltimore", Zipcode = "454 33"}, Company = new Company { Name = "Baltimore Police", CatchPhrase = "We will catch you"} },
				new User { Id = 7, Name = "Walt", Email = "Walt@teacher.com", Address = new Address { Street = "Old town", City = "Albuquerque", Zipcode = "256 31"}, Company = new Company { Name = "Chef", CatchPhrase = "Purity products"} },
				new User { Id = 8, Name = "Bill", Email = "Billie@Microsoft.com", Address = new Address { Street = "Rich street", City = "New York", Zipcode = "333 15"}, Company = new Company { Name = "Microsoft", CatchPhrase = "Microsoft Word"} },
				new User { Id = 9, Name = "Edward", Email = "Eddy@hidden.com", Address = new Address { Street = "private", City = "private", Zipcode = "999 99"}, Company = new Company { Name = "Self employed", CatchPhrase = "Don't trust your government"} },
				new User { Id = 10, Name = "50 cent", Email = "Fifty@Gunit.com", Address = new Address { Street = "Brooklyn street", City = "New York", Zipcode = "456 89"}, Company = new Company { Name = "GUnit", CatchPhrase = "I take you to the candy shop"} }
			};
		}
	}
}
