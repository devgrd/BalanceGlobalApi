using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ISubSistemasRepository : IRepository<SubSistemas>
    {

    }
    public class SubSistemasRepository : RepositoryBase<SubSistemas>, ISubSistemasRepository
    {
        public SubSistemasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}