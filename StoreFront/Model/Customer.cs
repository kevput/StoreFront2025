namespace StoreFront.Model
{
	public class Customer
	{
		public Customer(string name, DateTime dateOfBirth, string email)
		{
			Name = name;
			DateOfBirth = dateOfBirth;
			Email = email;
		}

		public string Name { get; }
		public DateTime DateOfBirth { get; }
		public string Email { get; }
	}
}
