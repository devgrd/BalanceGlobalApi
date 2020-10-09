using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IUsuariosRepository : IRepository<Usuarios>
    {

    }
    public class UsuariosRepository : RepositoryBase<Usuarios>, IUsuariosRepository
    {
        public UsuariosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}