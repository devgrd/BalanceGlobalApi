using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IAliasesRepository : IRepository<Aliases>
    {

    }
    public class AliasesRepository : RepositoryBase<Aliases>, IAliasesRepository
    {
        public AliasesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}