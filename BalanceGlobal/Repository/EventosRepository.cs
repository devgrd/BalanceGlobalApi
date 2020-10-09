using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IEventosRepository : IRepository<Eventos>
    {

    }
    public class EventosRepository : RepositoryBase<Eventos>, IEventosRepository
    {
        public EventosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}