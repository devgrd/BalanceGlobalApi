using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IFlujosRepository : IRepository<Flujos>
    {

    }
    public class FlujosRepository : RepositoryBase<Flujos>, IFlujosRepository
    {
        public FlujosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}