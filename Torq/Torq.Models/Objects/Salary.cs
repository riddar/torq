using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Torq.Models.Objects
{
	[DataContract]
	public class Salary
	{
		public Salary() => this.Schemas = new HashSet<Schema>();

		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string SalaryType { get; set; }
		[DataMember]
		public int Amount { get; set; }
		[DataMember]
		public Employee Employee { get; set; }
		[DataMember]
		public ICollection<Schema> Schemas { get; set; }
	}
}
