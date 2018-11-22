using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	public class RoleService : IDisposable, IRoleService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public RoleService() { }
		public void Dispose() => context.Dispose();

		public async Task<Role> CreateRole(Role role)
		{
			context.Roles.Add(role);
			await context.SaveChangesAsync();
			return await GetRoleByIdAsync(role.Id);
		}

		public async Task<Role> GetRoleByIdAsync(int id)
		{
			return await context.Roles.FirstOrDefaultAsync(r => r.Id == id);
		}

		public async Task<List<Role>> GetRoles()
		{
			return await context.Roles.ToListAsync();
		}

		public async void RemoveRole(Role role)
		{
			var result = await context.Roles.FirstOrDefaultAsync(r => r.Id == role.Id);

			context.Roles.Remove(result);
			await context.SaveChangesAsync();
		}

		public async Task<Role> UpdateRole(Role role)
		{
			var result = await context.Roles.FirstOrDefaultAsync(r => r.Id == role.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(role);
			await context.SaveChangesAsync();

			return role;
		}
	}
}
