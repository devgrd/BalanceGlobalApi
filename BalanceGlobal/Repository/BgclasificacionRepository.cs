using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IBgclasificacionRepository : IRepository<Bgclasificacion>
    {

    }
    public class BgclasificacionRepository : RepositoryBase<Bgclasificacion>, IBgclasificacionRepository
    {
        public BgclasificacionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}