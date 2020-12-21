using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPueblaTablaReporteBalanceLogEjecucionRepository : IRepository<PueblaTablaReporteBalanceLogEjecucion>
    {

    }
    public class PueblaTablaReporteBalanceLogEjecucionRepository : RepositoryBase<PueblaTablaReporteBalanceLogEjecucion>, IPueblaTablaReporteBalanceLogEjecucionRepository
    {
        public PueblaTablaReporteBalanceLogEjecucionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}