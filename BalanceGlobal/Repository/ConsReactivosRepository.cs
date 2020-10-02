using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsReactivosRepository : IRepository<ConsReactivos>
    {

    }
    public class ConsReactivosRepository : RepositoryBase<ConsReactivos>, IConsReactivosRepository
    {
        public ConsReactivosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}