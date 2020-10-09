using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPerfilesUsuarioRepository : IRepository<PerfilesUsuario>
    {

    }
    public class PerfilesUsuarioRepository : RepositoryBase<PerfilesUsuario>, IPerfilesUsuarioRepository
    {
        public PerfilesUsuarioRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}