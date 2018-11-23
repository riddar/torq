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
		Task<Role> CreateRole(Role role);
		[OperationContract]
		Task<Role> GetRoleByIdAsync(int id);
		[OperationContract]
		Task<List<Role>> GetRoles();
		[OperationContract]
		void RemoveRole(Role role);
		[OperationContract]
		Task<Role> UpdateRole(Role role);
	}
}