using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalanceGlobal.Repository
{
    public interface ISchemaColumnsRepository : IRepository<SchemaColumns>
    {
        Task<List<SchemaColumns>> GetSchemaColumns(string nombre);
    }
    public class SchemaColumnsRepository : RepositoryBase<SchemaColumns>, ISchemaColumnsRepository
    {
        public SchemaColumnsRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task<List<SchemaColumns>> GetSchemaColumns(string nombre)
        {
            var data = from sc in DataContext.SchemaColumns
                       join sd in DataContext.SchemaDef on sc.IdSchemaDef equals sd.IdSchemaDef
                       join od in DataContext.OrigenesDatos on sd.IdOrigenesDatos equals od.IdOrigenesDatos
                       join i in DataContext.Importadores on od.IdImportadores equals i.IdImportadores
                       where i.Nombre == nombre
                       select sc;

            return await data.ToListAsync();
                
        }
    }

}