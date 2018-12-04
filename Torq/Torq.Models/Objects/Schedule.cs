using System;
using System.ComponentModel.DataAnnotations;
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
		public int Employee_Id { get; set; }
		[DataMember]
		public virtual Employee Employee { get; set; }
		[DataMember]
		public virtual Salary Salary { get; set; }
	}
}
