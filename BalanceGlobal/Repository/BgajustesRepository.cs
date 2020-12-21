using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IBgajustesRepository : IRepository<Bgajustes>
    {

    }
    public class BgajustesRepository : RepositoryBase<Bgajustes>, IBgajustesRepository
    {
        public BgajustesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}