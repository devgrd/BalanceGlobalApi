using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IWorkflowItemRepository : IRepository<WorkflowItem>
    {

    }
    public class WorkflowItemRepository : RepositoryBase<WorkflowItem>, IWorkflowItemRepository
    {
        public WorkflowItemRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}