using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsDespachoRepository : IRepository<ConsDespacho>
    {

    }
    public class ConsDespachoRepository : RepositoryBase<ConsDespacho>, IConsDespachoRepository
    {
        public ConsDespachoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}