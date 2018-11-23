using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceContract]
	public interface ISalaryService
	{
		[OperationContract]
		Task<Salary> CreateSchema(Salary salary);
		[OperationContract]
		Task<List<Salary>> GetSalaries();
		[OperationContract]
		Task<Salary> GetSalaryByIdAsync(int id);
		[OperationContract]
		Task<Salary> UpdateSalary(Salary salary);
		[OperationContract]
		void RemoveSalary(Salary salary);
	}
}