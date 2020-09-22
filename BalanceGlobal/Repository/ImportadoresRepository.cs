using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImportadoresRepository : IRepository<Importadores>
    {

    }
    public class ImportadoresRepository : RepositoryBase<Importadores>, IImportadoresRepository
    {
        public ImportadoresRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}