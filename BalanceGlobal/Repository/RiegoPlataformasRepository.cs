using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IRiegoPlataformasRepository : IRepository<RiegoPlataformas>
    {

    }
    public class RiegoPlataformasRepository : RepositoryBase<RiegoPlataformas>, IRiegoPlataformasRepository
    {
        public RiegoPlataformasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}