using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITiposInventarioRepository : IRepository<TiposInventario>
    {

    }
    public class TiposInventarioRepository : RepositoryBase<TiposInventario>, ITiposInventarioRepository
    {
        public TiposInventarioRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}