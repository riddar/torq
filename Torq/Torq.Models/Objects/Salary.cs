using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Salary
	{
		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string SalaryType { get; set; }
		[DataMember]
		public int Amount { get; set; }
		[DataMember]
		public virtual Employee Employee { get; set; }
	}
}
