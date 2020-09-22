using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IFaenasSistemasRepository : IRepository<FaenasSistemas>
    {

    }
    public class FaenasSistemasRepository : RepositoryBase<FaenasSistemas>, IFaenasSistemasRepository
    {
        public FaenasSistemasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}