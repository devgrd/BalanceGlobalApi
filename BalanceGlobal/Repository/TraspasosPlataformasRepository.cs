using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITraspasosPlataformasRepository : IRepository<TraspasosPlataformas>
    {

    }
    public class TraspasosPlataformasRepository : RepositoryBase<TraspasosPlataformas>, ITraspasosPlataformasRepository
    {
        public TraspasosPlataformasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}