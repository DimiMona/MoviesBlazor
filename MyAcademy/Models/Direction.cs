using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
	public class Direction
	{
		[Column("direction_id", TypeName = "TINYINT")]
		public int Id { get; set; }

		[Column("direction_name", TypeName = "NVARCHAR(50)")]
		public string Name { get; set; }
	}
}
