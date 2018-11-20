using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

		[ForeignKey("EmployeeId")]
		public int EmployeeId { get; set; }
		[ForeignKey("SalaryId")]
		public int SalaryId { get; set; }
	}
}
