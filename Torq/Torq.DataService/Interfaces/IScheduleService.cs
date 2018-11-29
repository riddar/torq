using System.Collections.Generic;
using System.ServiceModel;

namespace Torq.DataService
{
	[ServiceContract]
	public interface IScheduleService
	{
		[OperationContract]
		Torq.Models.Objects.Schedule CreateSchedule(Torq.Models.Objects.Schedule schedule);
		[OperationContract]
		Torq.Models.Objects.Schedule GetScheduleById(int id);
		[OperationContract]
		IEnumerable<Torq.Models.Objects.Schedule> GetSchedules();
		[OperationContract]
		IEnumerable<Torq.Models.Objects.Schedule> GetSchedulesByEmployee(Torq.Models.Objects.Employee employee);
		[OperationContract]
		void RemoveSchedule(Torq.Models.Objects.Schedule schedule);
		[OperationContract]
		Torq.Models.Objects.Schedule UpdateSchedule(Torq.Models.Objects.Schedule schedule);
	}
}