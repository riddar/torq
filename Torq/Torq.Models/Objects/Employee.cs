using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Employee
	{
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
		public virtual Role Role { get; set; }
	}
}
