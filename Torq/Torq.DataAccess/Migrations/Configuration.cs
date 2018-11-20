namespace Torq.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Torq.DataAccess.Context.TorqDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Torq.DataAccess.Context.TorqDBContext context)
        {
			context.Employees.AddOrUpdate(e => e.Id,
				new Employee { }
			);
        }
    }
}
