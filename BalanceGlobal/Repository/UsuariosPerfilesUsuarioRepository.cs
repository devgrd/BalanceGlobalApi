using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IUsuariosPerfilesUsuarioRepository : IRepository<UsuariosPerfilesUsuario>
    {

    }
    public class UsuariosPerfilesUsuarioRepository : RepositoryBase<UsuariosPerfilesUsuario>, IUsuariosPerfilesUsuarioRepository
    {
        public UsuariosPerfilesUsuarioRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}