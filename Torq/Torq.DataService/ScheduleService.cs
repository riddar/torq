using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ServiceModel;
using Torq.DataAccess.Context;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class ScheduleService : IScheduleService, IDisposable
	{
		readonly TorqDBContext context = new TorqDBContext();

		public ScheduleService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Torq.Models.Objects.Schedule CreateSchedule(Torq.Models.Objects.Schedule schedule)
		{
			context.Schedules.Add(schedule);
			context.SaveChanges();
			return GetScheduleById(schedule.Id);
		}

		public Torq.Models.Objects.Schedule GetScheduleById(int id)
		{
			return context.Schedules.Include(s => s.Employee).FirstOrDefault(e => e.Id == id);
		}

		public IEnumerable<Torq.Models.Objects.Schedule> GetSchedules()
		{
			return context.Schedules.Include(e => e.Employee);
		}

		public void RemoveSchedule(Torq.Models.Objects.Schedule schedule)
		{
			var result = context.Schedules.Include(e => e.Employee).FirstOrDefault(e => e.Id == schedule.Id);

			context.Schedules.Remove(result);
			context.SaveChanges();
		}

		public Torq.Models.Objects.Schedule UpdateSchedule(Torq.Models.Objects.Schedule schedule)
		{
			var result = context.Schedules.Include(s => s.Employee).FirstOrDefault(s => s.Id == schedule.Id);

			if (schedule.Employee != null)
				schedule.Employee = context.Employees.Include(e => e.Role).FirstOrDefault(e => e.Id == schedule.Employee_Id);


			if (result == null)
				context.Schedules.Add(schedule);

			context.Entry(result).CurrentValues.SetValues(schedule);
			context.SaveChanges();

			return schedule;
		}

		public IEnumerable<Torq.Models.Objects.Schedule> GetSchedulesByEmployee(Torq.Models.Objects.Employee employee)
		{
			return context.Schedules.Include(e => e.Employee).Where(s => s.Employee.Id == employee.Id);
		}

		public IEnumerable<Torq.Models.Objects.Schedule> GetSchedulesByDay(DateTime date)
		{
			return context.Schedules.Include(e => e.Employee).Where(s => s.EndTime.Day == date.Day);
		}

		public IEnumerable<Torq.Models.Objects.Schedule> GetSchedulesByMonth(DateTime date)
		{
			return context.Schedules.Include(e => e.Employee).Where(s => s.EndTime.Month == date.Month);
		}

		public Torq.Models.Objects.Employee GetEmployeeById(int id)
		{
			return context.Employees.Include(e => e.Role).FirstOrDefault(e => e.Id == id);
		}
	}
}
