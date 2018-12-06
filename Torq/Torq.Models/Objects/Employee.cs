﻿using System.Collections.Generic;
using System.ComponentModel;
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
		public string UserName { get; set; }
		[DataMember]
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
		public int? RoleId { get; set; }
		[IgnoreDataMember]
		[ForeignKey("RoleId")]
		public virtual Role Role { get; set; }
		[DataMember]
		public virtual IList<Schedule> Schedules { get; set; }


	}
}
