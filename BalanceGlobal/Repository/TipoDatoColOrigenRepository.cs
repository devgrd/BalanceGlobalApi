using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoDatoColOrigenRepository : IRepository<TipoDatoColOrigen>
    {

    }
    public class TipoDatoColOrigenRepository : RepositoryBase<TipoDatoColOrigen>, ITipoDatoColOrigenRepository
    {
        public TipoDatoColOrigenRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}