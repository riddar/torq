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
		Salary CreateSalary(Salary salary);
		[OperationContract]
		List<Salary> GetSalaries();
		[OperationContract]
		Salary GetSalaryById(int id);
		[OperationContract]
		Salary UpdateSalary(Salary salary);
		[OperationContract]
		void RemoveSalary(Salary salary);
	}
}