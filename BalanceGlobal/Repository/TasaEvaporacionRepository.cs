using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITasaEvaporacionRepository : IRepository<TasaEvaporacion>
    {

    }
    public class TasaEvaporacionRepository : RepositoryBase<TasaEvaporacion>, ITasaEvaporacionRepository
    {
        public TasaEvaporacionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}