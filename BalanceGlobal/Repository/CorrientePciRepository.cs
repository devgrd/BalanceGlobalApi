using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICorrientePciRepository : IRepository<CorrientePci>
    {

    }
    public class CorrientePciRepository : RepositoryBase<CorrientePci>, ICorrientePciRepository
    {
        public CorrientePciRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}