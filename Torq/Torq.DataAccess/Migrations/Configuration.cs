namespace Torq.DataAccess.Migrations
{
	using System.Data.Entity.Migrations;
	using Torq.DataAccess.Context;
	using Torq.Models.Objects;

	internal sealed class Configuration : DbMigrationsConfiguration<TorqDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TorqDBContext context)
        {
			context.Roles.AddOrUpdate(r => r.Id,
				new Role { Id = 1, Title = "Worker" },
				new Role { Id = 2, Title = "Boss" }
			);

			context.Employees.AddOrUpdate(e => e.Id,
				new Employee { Id=1, FirstName="Anders", LastName="And", IsOnline=true, Role=new Role { Id=1 } },
				new Employee { Id=2, FirstName="Kalle", LastName="Anka", IsOnline=true, Role=new Role { Id=1 } },
				new Employee { Id=3, FirstName="Donald", LastName="Duck", IsOnline=true, Role = new Role { Id = 2 } },
				new Employee { Id=4, FirstName="Akku", LastName="Anka", IsOnline=false, Role = new Role { Id = 1 } }
			);

			context.Salaries.AddOrUpdate(s => s.Id,
				new Salary { Id=1, SalaryType="TimLön", Amount=100 },
				new Salary { Id=2, SalaryType="OB", Amount=200 }
			);


        }
    }
}
