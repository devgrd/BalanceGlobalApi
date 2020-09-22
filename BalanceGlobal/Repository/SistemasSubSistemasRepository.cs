using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISistemasSubSistemasRepository : IRepository<SistemasSubSistemas>
    {

    }
    public class SistemasSubSistemasRepository : RepositoryBase<SistemasSubSistemas>, ISistemasSubSistemasRepository
    {
        public SistemasSubSistemasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}