using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IOrigenesTraspasoPlataformasRepository : IRepository<OrigenesTraspasoPlataformas>
    {

    }
    public class OrigenesTraspasoPlataformasRepository : RepositoryBase<OrigenesTraspasoPlataformas>, IOrigenesTraspasoPlataformasRepository
    {
        public OrigenesTraspasoPlataformasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}