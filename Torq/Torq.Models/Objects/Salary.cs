using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Torq.Models.Objects
{
	public class Salary
	{
		public Salary() => this.Schemas = new HashSet<Schema>();

		[Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string SalaryType { get; set; }
		public int Amount { get; set; }

		public virtual ICollection<Schema> Schemas { get; set; }
	}
}
