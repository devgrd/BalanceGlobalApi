using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISchemaColumnsRepository : IRepository<SchemaColumns>
    {

    }
    public class SchemaColumnsRepository : RepositoryBase<SchemaColumns>, ISchemaColumnsRepository
    {
        public SchemaColumnsRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}