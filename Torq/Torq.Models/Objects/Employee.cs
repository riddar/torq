using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public class Employee
	{
		public Employee()
		{
			this.Schemas = new HashSet<Schema>();
		}

		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string FirstName { get; set; }
		[DataMember]
		public string LastName { get; set; }
		[DataMember]
		public bool IsOnline { get; set; }
		[DataMember]
		public Role Role { get; set; }
		[DataMember]
		public ICollection<Schema> Schemas { get; set; }
	}
}
