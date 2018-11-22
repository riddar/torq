using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ServiceModel;
using System.Threading.Tasks;
using Torq.DataAccess.Context;
using Torq.Models.Objects;

namespace Torq.DataService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class SchemaService : IDisposable, ISchemaService
	{
		readonly TorqDBContext context = new TorqDBContext();

		public SchemaService() { }
		public void Dispose() => context.Dispose();

		public async Task<Schema> CreateSchema(Schema schema)
		{
			context.Schemas.Add(schema);
			await context.SaveChangesAsync();
			return await GetSchemaByIdAsync(schema.Id);
		}

		public async Task<Schema> GetSchemaByIdAsync(int id)
		{
			return await context.Schemas.FirstOrDefaultAsync(s => s.Id == id);
		}

		public async Task<List<Schema>> GetSchemas()
		{
			return await context.Schemas.ToListAsync();
		}

		public async void RemoveSchema(Schema schema)
		{
			var result = await context.Schemas.FirstOrDefaultAsync(s => s.Id == schema.Id);

			context.Schemas.Remove(result);
			await context.SaveChangesAsync();
		}

		public async Task<Schema> UpdateRole(Schema schema)
		{
			var result = await context.Schemas.FirstOrDefaultAsync(s => s.Id == schema.Id);

			if (result == null)
				return null;

			context.Entry(result).CurrentValues.SetValues(schema);
			await context.SaveChangesAsync();

			return schema;
		}
	}
}
