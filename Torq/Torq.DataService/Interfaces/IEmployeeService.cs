using System.Collections.Generic;
using System.ServiceModel;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceContract]
	public interface IEmployeeService
	{
		[OperationContract]
		IEnumerable<Torq.Models.Objects.Employee> GetEmployees();
		[OperationContract]
		Torq.Models.Objects.Employee GetEmployeeById(int id);
		[OperationContract]
		Torq.Models.Objects.Employee GetEmployeeByUserName(string userName);
		[OperationContract]
		Torq.Models.Objects.Employee UpdateEmployee(Employee employee);
		[OperationContract]
		void RemoveEmployee(Employee employee);
		[OperationContract]
		Torq.Models.Objects.Employee CreateEmployee(Employee employee);
	}
}