using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	public class SalaryService : IDisposable, ISalaryService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public SalaryService() { }
		public void Dispose() => context.Dispose();

		public async Task<Salary> CreateSchema(Salary salary)
		{
			context.Salaries.Add(salary);
			await context.SaveChangesAsync();
			return await GetSalaryByIdAsync(salary.Id);
		}

		public async Task<Salary> GetSalaryByIdAsync(int id)
		{
			return await context.Salaries.FirstOrDefaultAsync(s => s.Id == id);
		}

		public async Task<List<Salary>> GetSalaries()
		{
			return await context.Salaries.ToListAsync();
		}

		public async void RemoveSalary(Salary salary)
		{
			var result = await context.Salaries.FirstOrDefaultAsync(s => s.Id == salary.Id);

			context.Salaries.Remove(result);
			await context.SaveChangesAsync();
		}

		public async Task<Salary> UpdateSalary(Salary salary)
		{
			var result = await context.Salaries.FirstOrDefaultAsync(s => s.Id == salary.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(salary);
			await context.SaveChangesAsync();

			return salary;
		}
	}
}
