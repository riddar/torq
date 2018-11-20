using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Torq.Models.Objects
{
	public class Schema
	{
		[Key]
		public int Id { get; set; }
		public bool ClockedIn { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
	}
}
