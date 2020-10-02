using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImportadoresUserParRepository : IRepository<ImportadoresUserPar>
    {

    }
    public class ImportadoresUserParRepository : RepositoryBase<ImportadoresUserPar>, IImportadoresUserParRepository
    {
        public ImportadoresUserParRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}