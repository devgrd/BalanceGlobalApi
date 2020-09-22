using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IOrigenesDatosRepository : IRepository<OrigenesDatos>
    {

    }
    public class OrigenesDatosRepository : RepositoryBase<OrigenesDatos>, IOrigenesDatosRepository
    {
        public OrigenesDatosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}