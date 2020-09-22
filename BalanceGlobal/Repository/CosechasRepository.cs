using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICosechasRepository : IRepository<Cosechas>
    {

    }
    public class CosechasRepository : RepositoryBase<Cosechas>, ICosechasRepository
    {
        public CosechasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}