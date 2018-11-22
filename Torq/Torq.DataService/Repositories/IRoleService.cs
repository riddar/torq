using System.Collections.Generic;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService.Repositories
{
	public interface IRoleService
	{
		Task<Role> CreateRole(Role role);
		Task<Role> GetRoleByIdAsync(int id);
		Task<List<Role>> GetRoles();
		void RemoveRole(Role role);
		Task<Role> UpdateRole(Role role);
	}
}