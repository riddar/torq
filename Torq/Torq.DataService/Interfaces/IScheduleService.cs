using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceContract]
	public interface IScheduleService
	{
		[OperationContract]
		Schedule CreateSchedule(Schedule schedule);
		[OperationContract]
		Schedule GetScheduleById(int id);
		[OperationContract]
		IEnumerable<Schedule> GetSchedules();
		[OperationContract]
		void RemoveSchedule(Schedule schedule);
		[OperationContract]
		Schedule UpdateSchedule(Schedule schedule);
	}
}