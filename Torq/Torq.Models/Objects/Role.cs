using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Role
	{
		public Role() => this.Employees = new List<Employee>();
		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Title { get; set; }
		[IgnoreDataMember]
		public List<Employee> Employees { get; set; }
	}
}
