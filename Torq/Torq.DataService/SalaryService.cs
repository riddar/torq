using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Torq.DataAccess.Context;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class SalaryService : IDisposable, ISalaryService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public SalaryService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Torq.Models.Objects.Salary CreateSalary(Torq.Models.Objects.Salary salary)
		{
			context.Salaries.Add(salary);
			context.SaveChanges();
			return GetSalaryById(salary.Id);
		}

		public Torq.Models.Objects.Salary GetSalaryById(int id)
		{
			return context.Salaries.FirstOrDefault(s => s.Id == id);
		}

		public List<Torq.Models.Objects.Salary> GetSalaries()
		{
			return context.Salaries.ToList();
		}

		public void RemoveSalary(Torq.Models.Objects.Salary salary)
		{
			var result = context.Salaries.FirstOrDefault(s => s.Id == salary.Id);

			context.Salaries.Remove(result);
			context.SaveChanges();
		}

		public Torq.Models.Objects.Salary UpdateSalary(Torq.Models.Objects.Salary salary)
		{
			var result = context.Salaries.FirstOrDefault(s => s.Id == salary.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(salary);
			context.SaveChanges();

			return salary;
		}
	}
}
