using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoHeaderRepository : IRepository<TipoHeader>
    {

    }
    public class TipoHeaderRepository : RepositoryBase<TipoHeader>, ITipoHeaderRepository
    {
        public TipoHeaderRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}