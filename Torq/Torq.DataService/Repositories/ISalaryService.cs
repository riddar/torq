using System.Collections.Generic;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService.Repositories
{
	public interface ISalaryService
	{
		Task<Salary> CreateSchema(Salary salary);
		Task<List<Salary>> GetSalaries();
		Task<Salary> GetSalaryByIdAsync(int id);
		Task<Salary> UpdateSalary(Salary salary);
		void RemoveSalary(Salary salary);
	}
}