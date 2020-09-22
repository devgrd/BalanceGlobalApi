using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IFaenasRepository : IRepository<Faenas>
    {

    }
    public class FaenasRepository : RepositoryBase<Faenas>, IFaenasRepository
    {
        public FaenasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}