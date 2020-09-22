using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImportDestinoRepository : IRepository<ImportDestino>
    {

    }
    public class ImportDestinoRepository : RepositoryBase<ImportDestino>, IImportDestinoRepository
    {
        public ImportDestinoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}