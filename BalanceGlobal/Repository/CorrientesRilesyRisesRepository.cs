using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICorrientesRilesyRisesRepository : IRepository<CorrientesRilesyRises>
    {

    }
    public class CorrientesRilesyRisesRepository : RepositoryBase<CorrientesRilesyRises>, ICorrientesRilesyRisesRepository
    {
        public CorrientesRilesyRisesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}