using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

		public virtual 
	}
}
