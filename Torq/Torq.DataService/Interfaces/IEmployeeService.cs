using System.Collections.Generic;
using System.ServiceModel;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceContract]
	public interface IEmployeeService
	{
		[OperationContract]
		IEnumerable<Employee> GetEmployees();
		[OperationContract]
		Employee GetEmployeeById(int id);
		[OperationContract]
		Employee UpdateEmployee(Employee employee);
		[OperationContract]
		void RemoveEmployee(Employee employee);
		[OperationContract]
		Employee CreateEmployee(Employee employee);
	}
}