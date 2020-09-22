using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsInvCarmenRepository : IRepository<ConsInvCarmen>
    {

    }
    public class ConsInvCarmenRepository : RepositoryBase<ConsInvCarmen>, IConsInvCarmenRepository
    {
        public ConsInvCarmenRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}