using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IChangeTrackingDetailRepository : IRepository<ChangeTrackingDetail>
    {

    }
    public class ChangeTrackingDetailRepository : RepositoryBase<ChangeTrackingDetail>, IChangeTrackingDetailRepository
    {
        public ChangeTrackingDetailRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}