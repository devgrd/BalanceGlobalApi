using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPciacopiosCliRepository : IRepository<PciacopiosCli>
    {

    }
    public class PciacopiosCliRepository : RepositoryBase<PciacopiosCli>, IPciacopiosCliRepository
    {
        public PciacopiosCliRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}