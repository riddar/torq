using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class EmployeeService : IEmployeeService, IDisposable
	{
		readonly TorqDBContext context = new TorqDBContext();

		public EmployeeService() { }
		public void Dispose() => context.Dispose();

		public Employee CreateEmployee(Employee employee)
		{
			context.Employees.Add(employee);
			context.SaveChanges();
			return GetEmployeeById(employee.Id);
		}

		public Employee GetEmployeeById(int id)
		{
			return context.Employees.FirstOrDefault(e => e.Id == id);
		}

		public List<Employee> GetEmployees()
		{
			return context.Employees.ToList();
		}

		public void RemoveEmployee(Employee employee)
		{
			var result = context.Employees.FirstOrDefault(e => e.Id == employee.Id);

			context.Employees.Remove(result);
			context.SaveChanges();
		}

		public Employee UpdateEmployee(Employee employee)
		{
			var result = context.Employees.FirstOrDefault(e => e.Id == employee.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(employee);
			context.SaveChanges();

			return employee;
		}

	}
}
