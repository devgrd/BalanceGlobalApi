using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITipoInfraestructurasRepository : IRepository<TipoInfraestructuras>
    {

    }
    public class TipoInfraestructurasRepository : RepositoryBase<TipoInfraestructuras>, ITipoInfraestructurasRepository
    {
        public TipoInfraestructurasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}