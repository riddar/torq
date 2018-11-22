using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService.Repositories
{
	public class EmployeeService : IDisposable, IEmployeeService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public EmployeeService() { }
		public void Dispose() => context.Dispose();

		public async Task<Employee> CreateEmployee(Employee employee)
		{
			context.Employees.Add(employee);
			await context.SaveChangesAsync();
			return await GetEmployeeByIdAsync(employee.Id);
		}

		public async Task<Employee> GetEmployeeByIdAsync(int id)
		{
			return await context.Employees.FirstOrDefaultAsync(e => e.Id == id);
		}

		public async Task<List<Employee>> GetEmployees()
		{
			return await context.Employees.ToListAsync();
		}

		public async void RemoveEmployee(Employee employee)
		{
			var result = await context.Employees.FirstOrDefaultAsync(e => e.Id == employee.Id);

			context.Employees.Remove(result);
			context.SaveChanges();
		}

		public async Task<Employee> UpdateEmployee(Employee employee)
		{
			var result = await context.Employees.FirstOrDefaultAsync(e => e.Id == employee.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(employee);
			context.SaveChanges();

			return employee;
		}
	}
}
