using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService.Repositories
{
	[ServiceContract]
	public interface IEmployeeService
	{
		[OperationContract]
		Task<Employee> CreateEmployee(Employee employee);
		[OperationContract]
		Task<Employee> GetEmployeeByIdAsync(int id);
		[OperationContract]
		Task<List<Employee>> GetEmployees();
		[OperationContract]
		Task<Employee> UpdateEmployee(Employee employee);
		[OperationContract]
		void RemoveEmployee(Employee employee);
	}
}