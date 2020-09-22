using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISistemasRepository : IRepository<Sistemas>
    {

    }
    public class SistemasRepository : RepositoryBase<Sistemas>, ISistemasRepository
    {
        public SistemasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}