using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPeriodosOperacionalesRepository : IRepository<PeriodosOperacionales>
    {

    }
    public class PeriodosOperacionalesRepository : RepositoryBase<PeriodosOperacionales>, IPeriodosOperacionalesRepository
    {
        public PeriodosOperacionalesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}