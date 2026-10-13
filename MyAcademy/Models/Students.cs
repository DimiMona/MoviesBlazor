namespace MyAcademy.Models
{
	public class Students
	{
		public int Id { get; set; }
		public string LastName { get; set; }

		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public DateOnly BirthDate { get; set; }

		public string Email { get; set; }

		public int PhoneNumber { get; set; }

		public string? Photo { get; set; }

		public int group { get; set; }
	}
}
