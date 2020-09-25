using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IReinyeccionRepository : IRepository<Reinyeccion>
    {

    }
    public class ReinyeccionRepository : RepositoryBase<Reinyeccion>, IReinyeccionRepository
    {
        public ReinyeccionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}