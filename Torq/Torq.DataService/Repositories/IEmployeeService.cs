using System.Collections.Generic;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService.Repositories
{
	public interface IEmployeeService
	{
		Task<Employee> CreateEmployee(Employee employee);
		Task<Employee> GetEmployeeByIdAsync(int id);
		Task<List<Employee>> GetEmployees();
		Task<Employee> UpdateEmployee(Employee employee);
		void RemoveEmployee(Employee employee);
	}
}