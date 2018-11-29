using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceContract]
	public interface IRoleService
	{
		[OperationContract]
		Torq.Models.Objects.Role CreateRole(Role role);
		[OperationContract]
		Torq.Models.Objects.Role GetRoleById(int id);
		[OperationContract]
		IEnumerable<Torq.Models.Objects.Role> GetRoles();
		[OperationContract]
		void RemoveRole(Torq.Models.Objects.Role role);
		[OperationContract]
		Torq.Models.Objects.Role UpdateRole(Torq.Models.Objects.Role role);
	}
}