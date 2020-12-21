using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BalanceGlobal.Repository
{
    public interface ISchemaColumnsWarningRepository : IRepository<SchemaColumnsWarning>
    {
        Task<List<SchemaColumnsWarning>> GetSchemaColumnsWarning(string nombre);
    }
    public class SchemaColumnsWarningRepository : RepositoryBase<SchemaColumnsWarning>, ISchemaColumnsWarningRepository
    {
        public SchemaColumnsWarningRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task<List<SchemaColumnsWarning>> GetSchemaColumnsWarning(string nombre)
        {
            var data = from sc in DataContext.SchemaColumnsWarning
                       join sd in DataContext.SchemaDef on sc.IdSchemaDef equals sd.IdSchemaDef
                       join od in DataContext.OrigenesDatos on sd.IdOrigenesDatos equals od.IdOrigenesDatos
                       join i in DataContext.Importadores on od.IdImportadores equals i.IdImportadores
                       where i.Nombre == nombre
                       select sc;

            return await data.ToListAsync();
        }
    }
}