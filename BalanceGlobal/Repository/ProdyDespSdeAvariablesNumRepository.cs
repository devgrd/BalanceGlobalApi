using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IProdyDespSdeAvariablesNumRepository : IRepository<ProdyDespSdeAvariablesNum>
    {

    }
    public class ProdyDespSdeAvariablesNumRepository : RepositoryBase<ProdyDespSdeAvariablesNum>, IProdyDespSdeAvariablesNumRepository
    {
        public ProdyDespSdeAvariablesNumRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}