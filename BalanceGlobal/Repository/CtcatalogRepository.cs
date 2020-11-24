using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICtcatalogRepository : IRepository<Ctcatalog>
    {

    }
    public class CtcatalogRepository : RepositoryBase<Ctcatalog>, ICtcatalogRepository
    {
        public CtcatalogRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}