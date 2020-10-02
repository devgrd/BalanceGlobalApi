using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoSalRepository : IRepository<TipoSal>
    {

    }
    public class TipoSalRepository : RepositoryBase<TipoSal>, ITipoSalRepository
    {
        public TipoSalRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}