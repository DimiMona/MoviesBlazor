namespace MyAcademy.Models
{
	public class Group
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int direction { get; set; }

		public DateOnly StartDate { get; set; }

		public TimeOnly StartTime { get; set; }

		public int LearningDays { get; set; }


	}
}
