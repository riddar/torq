using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class RoleService : IDisposable, IRoleService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public RoleService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Role CreateRole(Role role)
		{
			context.Roles.Add(role);
			context.SaveChanges();
			return GetRoleById(role.Id);
		}

		public Role GetRoleById(int id)
		{
			return context.Roles.FirstOrDefault(r => r.Id == id);
		}

		public IEnumerable<Role> GetRoles()
		{
			return context.Roles;
		}

		public void RemoveRole(Role role)
		{
			var result = context.Roles.FirstOrDefault(r => r.Id == role.Id);

			context.Roles.Remove(result);
			context.SaveChanges();
		}

		public Role UpdateRole(Role role)
		{
			var result = context.Roles.FirstOrDefault(r => r.Id == role.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(role);
			context.SaveChanges();

			return role;
		}
	}
}
