using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Employee
	{
		public Employee() => this.Schedules = new HashSet<Schedule>();

		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		[DisplayName("User Name")]
		[Required(ErrorMessage ="username is Required")]
		public string UserName { get; set; }
		[DataMember]
		[Required(ErrorMessage = "Password is Required")]
		public string Password { get; set; }
		[DataMember]
		public string FirstName { get; set; }
		[DataMember]
		public string LastName { get; set; }
		[DataMember]
		public string Email { get; set; }
		[DataMember]
		public bool IsOnline { get; set; }
		[DataMember]
		public string LoginError { get; set; }
		[DataMember]
		public virtual Role Role { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Schedule> Schedules { get; set; }


	}
}
