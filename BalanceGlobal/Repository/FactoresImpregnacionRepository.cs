using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IFactoresImpregnacionRepository : IRepository<FactoresImpregnacion>
    {

    }
    public class FactoresImpregnacionRepository : RepositoryBase<FactoresImpregnacion>, IFactoresImpregnacionRepository
    {
        public FactoresImpregnacionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}