using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IReactivosRepository : IRepository<Reactivos>
    {

    }
    public class ReactivosRepository : RepositoryBase<Reactivos>, IReactivosRepository
    {
        public ReactivosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}