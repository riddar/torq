using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Torq.Models.Objects
{
	public class Role
	{
		public Role()
		{
			this.Employees = new HashSet<Employee>();
		}

		[Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string Title { get; set; }

		public virtual ICollection<Employee> Employees { get; set; }
	}
}
