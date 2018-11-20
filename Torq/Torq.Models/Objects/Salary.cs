using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Torq.Models.Objects
{
	public class Salary
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string SalaryType { get; set; }
		public int Amount { get; set; }
	}
}
