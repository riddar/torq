using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public class Schema
	{
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
		public Employee Employee { get; set; }
		[DataMember]
		public Salary Salary { get; set; }
	}
}
