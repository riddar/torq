using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class SalaryService : IDisposable, ISalaryService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public SalaryService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Salary CreateSalary(Salary salary)
		{
			context.Salaries.Add(salary);
			context.SaveChanges();
			return GetSalaryById(salary.Id);
		}

		public Salary GetSalaryById(int id)
		{
			return context.Salaries.FirstOrDefault(s => s.Id == id);
		}

		public List<Salary> GetSalaries()
		{
			return context.Salaries.ToList();
		}

		public void RemoveSalary(Salary salary)
		{
			var result = context.Salaries.FirstOrDefault(s => s.Id == salary.Id);

			context.Salaries.Remove(result);
			context.SaveChanges();
		}

		public Salary UpdateSalary(Salary salary)
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
