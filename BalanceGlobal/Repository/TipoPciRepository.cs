using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoPciRepository : IRepository<TipoPci>
    {

    }
    public class TipoPciRepository : RepositoryBase<TipoPci>, ITipoPciRepository
    {
        public TipoPciRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}