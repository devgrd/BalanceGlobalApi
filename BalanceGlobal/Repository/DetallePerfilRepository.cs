using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IDetallePerfilRepository : IRepository<DetallePerfil>
    {

    }
    public class DetallePerfilRepository : RepositoryBase<DetallePerfil>, IDetallePerfilRepository
    {
        public DetallePerfilRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}