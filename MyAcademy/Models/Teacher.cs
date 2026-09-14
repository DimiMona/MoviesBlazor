namespace MyAcademy.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		public string LastName { get; set; }

		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public DateOnly BirthDate { get; set; }

		public string Email { get; set; }

		public int PhoneNumber { get; set; }

		public string? Photo { get; set; }
		public DateOnly WorkSince { get; set; }
		public decimal? Rate { get; set; }

	}
}
