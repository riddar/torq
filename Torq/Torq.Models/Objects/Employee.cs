using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Torq.Models.Objects
{
	public class Employee
	{
		public Employee()
		{
			this.Schemas = new HashSet<Schema>();
		}

		[Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string FirstName { get; set; }
		[MaxLength(50)]
		public string LastName { get; set; }
		public bool IsOnline { get; set; }

		public virtual Role Role { get; set; }

		public virtual ICollection<Schema> Schemas { get; set; }
	}
}
