using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Torq.DataAccess.Context;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class RoleService : IDisposable, IRoleService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public RoleService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Torq.Models.Objects.Role CreateRole(Torq.Models.Objects.Role role)
		{
			context.Roles.Add(role);
			context.SaveChanges();
			return GetRoleById(role.Id);
		}

		public Torq.Models.Objects.Role GetRoleById(int id)
		{
			return context.Roles.FirstOrDefault(r => r.Id == id);
		}

		public IEnumerable<Torq.Models.Objects.Role> GetRoles()
		{
			return context.Roles;
		}

		public void RemoveRole(Torq.Models.Objects.Role role)
		{
			var result = context.Roles.FirstOrDefault(r => r.Id == role.Id);

			context.Roles.Remove(result);
			context.SaveChanges();
		}

		public Torq.Models.Objects.Role UpdateRole(Torq.Models.Objects.Role role)
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
