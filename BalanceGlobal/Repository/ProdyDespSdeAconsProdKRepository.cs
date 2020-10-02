using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IProdyDespSdeAconsProdKRepository : IRepository<ProdyDespSdeAconsProdK>
    {

    }
    public class ProdyDespSdeAconsProdKRepository : RepositoryBase<ProdyDespSdeAconsProdK>, IProdyDespSdeAconsProdKRepository
    {
        public ProdyDespSdeAconsProdKRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}