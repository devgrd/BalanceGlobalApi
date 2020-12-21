using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IBgcorrientesRepository : IRepository<Bgcorrientes>
    {

    }
    public class BgcorrientesRepository : RepositoryBase<Bgcorrientes>, IBgcorrientesRepository
    {
        public BgcorrientesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}