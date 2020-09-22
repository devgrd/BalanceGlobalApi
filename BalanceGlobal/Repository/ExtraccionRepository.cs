using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IExtraccionRepository : IRepository<Extraccion>
    {

    }
    public class ExtraccionRepository : RepositoryBase<Extraccion>, IExtraccionRepository
    {
        public ExtraccionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}