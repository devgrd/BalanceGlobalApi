using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPorteosRepository : IRepository<Porteos>
    {

    }
    public class PorteosRepository : RepositoryBase<Porteos>, IPorteosRepository
    {
        public PorteosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}