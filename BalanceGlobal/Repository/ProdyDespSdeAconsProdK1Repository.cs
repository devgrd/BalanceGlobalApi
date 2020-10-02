using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IProdyDespSdeAconsProdK1Repository : IRepository<ProdyDespSdeAconsProdK1>
    {

    }
    public class ProdyDespSdeAconsProdK1Repository : RepositoryBase<ProdyDespSdeAconsProdK1>, IProdyDespSdeAconsProdK1Repository
    {
        public ProdyDespSdeAconsProdK1Repository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}