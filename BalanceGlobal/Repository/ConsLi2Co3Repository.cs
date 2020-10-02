using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsLi2Co3Repository : IRepository<ConsLi2Co3>
    {

    }
    public class ConsLi2Co3Repository : RepositoryBase<ConsLi2Co3>, IConsLi2Co3Repository
    {
        public ConsLi2Co3Repository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}