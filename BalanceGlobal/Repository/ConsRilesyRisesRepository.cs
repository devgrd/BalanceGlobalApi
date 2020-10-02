using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsRilesyRisesRepository : IRepository<ConsRilesyRises>
    {

    }
    public class ConsRilesyRisesRepository : RepositoryBase<ConsRilesyRises>, IConsRilesyRisesRepository
    {
        public ConsRilesyRisesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}