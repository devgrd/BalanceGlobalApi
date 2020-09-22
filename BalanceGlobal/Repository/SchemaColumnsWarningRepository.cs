using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISchemaColumnsWarningRepository : IRepository<SchemaColumnsWarning>
    {

    }
    public class SchemaColumnsWarningRepository : RepositoryBase<SchemaColumnsWarning>, ISchemaColumnsWarningRepository
    {
        public SchemaColumnsWarningRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}