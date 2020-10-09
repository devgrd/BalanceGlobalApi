using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IInfraestructurasReinyeccionRepository : IRepository<InfraestructurasReinyeccion>
    {

    }
    public class InfraestructurasReinyeccionRepository : RepositoryBase<InfraestructurasReinyeccion>, IInfraestructurasReinyeccionRepository
    {
        public InfraestructurasReinyeccionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}