using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System.Threading.Tasks;

namespace BalanceGlobal.Repository
{
    public interface IPeriodosRepository : IRepository<Periodos>
    {
    }
    public class PeriodosRepository : RepositoryBase<Periodos>, IPeriodosRepository
    {
        public PeriodosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

    }

}