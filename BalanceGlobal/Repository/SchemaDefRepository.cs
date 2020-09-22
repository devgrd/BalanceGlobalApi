using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISchemaDefRepository : IRepository<SchemaDef>
    {

    }
    public class SchemaDefRepository : RepositoryBase<SchemaDef>, ISchemaDefRepository
    {
        public SchemaDefRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}