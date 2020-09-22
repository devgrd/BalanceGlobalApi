using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IBombasRepository : IRepository<Bombas>
    {

    }
    public class BombasRepository : RepositoryBase<Bombas>, IBombasRepository
    {
        public BombasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}