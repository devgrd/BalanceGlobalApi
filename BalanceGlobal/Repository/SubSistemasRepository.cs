using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISubsistemasRepository : IRepository<Subsistemas>
    {

    }
    public class SubsistemasRepository : RepositoryBase<Subsistemas>, ISubsistemasRepository
    {
        public SubsistemasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}