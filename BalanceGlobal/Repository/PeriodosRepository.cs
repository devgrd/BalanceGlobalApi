using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System.Threading.Tasks;

namespace BalanceGlobal.Repository
{
    public interface IPeriodosRepository : IRepository<Periodos>
    {
        Task AddAsync(Periodos entity, string context);
    }
    public class PeriodosRepository : RepositoryBase<Periodos>, IPeriodosRepository
    {
        public PeriodosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task AddAsync(Periodos entity, string context)
        {
            await AddAsync(entity);
            await SaveChangesAsync(context);
        }
    }

}