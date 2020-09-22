using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImportacionesUserParValuesRepository : IRepository<ImportacionesUserParValues>
    {

    }
    public class ImportacionesUserParValuesRepository : RepositoryBase<ImportacionesUserParValues>, IImportacionesUserParValuesRepository
    {
        public ImportacionesUserParValuesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}