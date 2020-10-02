using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IEvaporacionInfiltracionRepository : IRepository<EvaporacionInfiltracion>
    {

    }
    public class EvaporacionInfiltracionRepository : RepositoryBase<EvaporacionInfiltracion>, IEvaporacionInfiltracionRepository
    {
        public EvaporacionInfiltracionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}