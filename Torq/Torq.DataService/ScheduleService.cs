using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class ScheduleService : IDisposable, IScheduleService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public ScheduleService() { context.Configuration.ProxyCreationEnabled = false; }
		public void Dispose() => context.Dispose();

		public Schedule CreateSchedule(Schedule schedule)
		{
			context.Schedules.Add(schedule);
			context.SaveChanges();
			return GetScheduleById(schedule.Id);
		}

		public Schedule GetScheduleById(int id)
		{
			return context.Schedules.FirstOrDefault(s => s.Id == id);
		}

		public IEnumerable<Schedule> GetSchedules()
		{
			return context.Schedules.ToList();
		}

		public void RemoveSchedule(Schedule schedule)
		{
			var result = context.Schedules.FirstOrDefault(s => s.Id == schedule.Id);

			context.Schedules.Remove(result);
			context.SaveChangesAsync();
		}

		public Schedule UpdateSchedule(Schedule schedule)
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
