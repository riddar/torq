using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Torq.DataAccess.Context;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class ScheduleService : IDisposable, IScheduleService
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
			return context.Schedules.FirstOrDefault(s => s.Id == id);
		}

		public IEnumerable<Torq.Models.Objects.Schedule> GetSchedules()
		{
			return context.Schedules.ToList();
		}

		public IEnumerable<Torq.Models.Objects.Schedule> GetSchedulesByEmployee(Torq.Models.Objects.Employee employee)
		{
			return context.Schedules.Where(s => s.Employee.UserName == employee.UserName).ToList();
		}

		public void RemoveSchedule(Torq.Models.Objects.Schedule schedule)
		{
			var result = context.Schedules.FirstOrDefault(s => s.Id == schedule.Id);

			context.Schedules.Remove(result);
			context.SaveChangesAsync();
		}

		public Torq.Models.Objects.Schedule UpdateSchedule(Torq.Models.Objects.Schedule schedule)
		{
			var result = context.Schedules.FirstOrDefault(s => s.Id == schedule.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(schedule);
			context.SaveChanges();

			return schedule;
		}
	}
}
