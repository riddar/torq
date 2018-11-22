using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Torq.Models.Objects;

namespace Torq.DataService.Repositories
{
	[ServiceContract]
	public interface ISchemaService
	{
		[OperationContract]
		Task<Schema> CreateSchema(Schema schema);
		[OperationContract]
		Task<Schema> GetSchemaByIdAsync(int id);
		[OperationContract]
		Task<List<Schema>> GetSchemas();
		[OperationContract]
		void RemoveSchema(Schema schema);
		[OperationContract]
		Task<Schema> UpdateRole(Schema schema);
	}
}