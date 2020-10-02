using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IInventariosAtacamaRepository : IRepository<InventariosAtacama>
    {

    }
    public class InventariosAtacamaRepository : RepositoryBase<InventariosAtacama>, IInventariosAtacamaRepository
    {
        public InventariosAtacamaRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}