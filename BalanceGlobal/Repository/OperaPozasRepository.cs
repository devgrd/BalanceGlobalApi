using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IOperaPozasRepository : IRepository<OperaPozas>
    {

    }
    public class OperaPozasRepository : RepositoryBase<OperaPozas>, IOperaPozasRepository
    {
        public OperaPozasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}