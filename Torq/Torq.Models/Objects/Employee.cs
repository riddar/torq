using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Torq.Models.Objects
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string FirstName { get; set; }
		[MaxLength(50)]
		public string LastName { get; set; }
		public bool IsOnline { get; set; }
		[ForeignKey("RoleId")]
		public int RoleId { get; set; }

		public virtual ICollection<Schema> Schemas { get; set; }
	}
}
