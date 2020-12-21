using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoDatoControlRepository : IRepository<TipoDatoControl>
    {

    }
    public class TipoDatoControlRepository : RepositoryBase<TipoDatoControl>, ITipoDatoControlRepository
    {
        public TipoDatoControlRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}