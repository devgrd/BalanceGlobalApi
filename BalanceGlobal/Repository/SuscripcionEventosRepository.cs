using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISuscripcionEventosRepository : IRepository<SuscripcionEventos>
    {

    }
    public class SuscripcionEventosRepository : RepositoryBase<SuscripcionEventos>, ISuscripcionEventosRepository
    {
        public SuscripcionEventosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}