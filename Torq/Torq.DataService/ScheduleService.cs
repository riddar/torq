using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ServiceModel;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class ScheduleService : IEmployeeService, IDisposable
	{
		readonly TorqDBContext context = new TorqDBContext();

		public ScheduleService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Torq.Models.Objects.Employee CreateEmployee(Torq.Models.Objects.Employee employee)
		{
			context.Employees.Add(employee);
			context.SaveChanges();
			return GetEmployeeById(employee.Id);
		}

		public Torq.Models.Objects.Employee GetEmployeeById(int id)
		{
			return context.Employees.Include(e => e.Role).FirstOrDefault(e => e.Id == id);
		}

		public Torq.Models.Objects.Employee GetEmployeeByUserName(string userName)
		{
			return context.Employees.Include(e => e.Role).FirstOrDefault(e => e.UserName == userName);
		}

		public IEnumerable<Torq.Models.Objects.Employee> GetEmployees()
		{
			return context.Employees.Include(e => e.Role);
		}

		public void RemoveEmployee(Torq.Models.Objects.Employee employee)
		{
			var result = context.Employees.Include(e => e.Role).FirstOrDefault(e => e.Id == employee.Id);

			context.Employees.Remove(result);
			context.SaveChanges();
		}

		public Torq.Models.Objects.Employee UpdateEmployee(Torq.Models.Objects.Employee employee)
		{
			var result = context.Employees.Include(e => e.Role).FirstOrDefault(e => e.Id == employee.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(employee);
			context.SaveChanges();

			return employee;
		}

	}
}
