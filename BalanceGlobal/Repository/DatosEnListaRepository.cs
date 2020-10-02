using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IDatosEnListaRepository : IRepository<DatosEnLista>
    {

    }
    public class DatosEnListaRepository : RepositoryBase<DatosEnLista>, IDatosEnListaRepository
    {
        public DatosEnListaRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}