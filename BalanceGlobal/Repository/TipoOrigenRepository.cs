using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoOrigenRepository : IRepository<TipoOrigen>
    {

    }
    public class TipoOrigenRepository : RepositoryBase<TipoOrigen>, ITipoOrigenRepository
    {
        public TipoOrigenRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}