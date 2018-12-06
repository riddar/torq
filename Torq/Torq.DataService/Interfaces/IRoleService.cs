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
		Role CreateRole(Role role);
		[OperationContract]
		Role GetRoleById(int id);
		[OperationContract]
		IEnumerable<Role> GetRoles();
		[OperationContract]
		void RemoveRole(Role role);
		[OperationContract]
		Role UpdateRole(Role role);
	}
}