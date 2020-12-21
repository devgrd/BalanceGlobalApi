using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IBgtiposRepository : IRepository<Bgtipos>
    {

    }
    public class BgtiposRepository : RepositoryBase<Bgtipos>, IBgtiposRepository
    {
        public BgtiposRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}