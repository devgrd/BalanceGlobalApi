using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IInfraestruturasReinyeccionRepository : IRepository<InfraestruturasReinyeccion>
    {

    }
    public class InfraestruturasReinyeccionRepository : RepositoryBase<InfraestruturasReinyeccion>, IInfraestruturasReinyeccionRepository
    {
        public InfraestruturasReinyeccionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}