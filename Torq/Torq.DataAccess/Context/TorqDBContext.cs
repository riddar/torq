using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Torq.Models.Objects;

namespace Torq.DataAccess.Context
{
	public class TorqDBContext : DbContext
	{
		public TorqDBContext() : base("Torq") { }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Salary> Salaries { get; set; }
		public DbSet<Schema> Schemas { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
