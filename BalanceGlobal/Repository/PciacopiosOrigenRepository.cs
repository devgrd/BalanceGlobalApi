using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPciacopiosOrigenRepository : IRepository<PciacopiosOrigen>
    {

    }
    public class PciacopiosOrigenRepository : RepositoryBase<PciacopiosOrigen>, IPciacopiosOrigenRepository
    {
        public PciacopiosOrigenRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}