using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Torq.Models.Objects
{
	public class Role
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string Title { get; set; }
	}
}
