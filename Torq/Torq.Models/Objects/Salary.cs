using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Salary
	{
		public Salary() => this.Schedules = new HashSet<Schedule>();

		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string SalaryType { get; set; }
		[DataMember]
		public int Amount { get; set; }
		[IgnoreDataMember]
		public ICollection<Schedule> Schedules { get; set; }
	}
}
