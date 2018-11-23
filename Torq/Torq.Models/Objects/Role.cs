using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Role
	{
		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Title { get; set; }
	}
}
