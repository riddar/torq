using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Schedule
	{
		public Schedule() { }

		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public bool ClockedIn { get; set; }
		[DataMember]
		public DateTime StartTime { get; set; }
		[DataMember]
		public DateTime EndTime { get; set; }
		[DataMember]
		public int? EmployeeId { get; set; }
		[IgnoreDataMember]
		[ForeignKey("EmployeeId")]
		public virtual Employee Employee { get; set; }
		[DataMember]
		public int? SalaryId { get; set; }
		[IgnoreDataMember]
		[ForeignKey("SalaryId")]
		public virtual Salary Salary { get; set; }
	}
}
