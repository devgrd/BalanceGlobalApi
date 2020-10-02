using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICkmopIiquimaPorteoRepository : IRepository<CkmopIiquimaPorteo>
    {

    }
    public class CkmopIiquimaPorteoRepository : RepositoryBase<CkmopIiquimaPorteo>, ICkmopIiquimaPorteoRepository
    {
        public CkmopIiquimaPorteoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}