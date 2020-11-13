using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IChangeTrackingHeaderRepository : IRepository<ChangeTrackingHeader>
    {

    }
    public class ChangeTrackingHeaderRepository : RepositoryBase<ChangeTrackingHeader>, IChangeTrackingHeaderRepository
    {
        public ChangeTrackingHeaderRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}