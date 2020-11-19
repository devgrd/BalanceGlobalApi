using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Queries;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Repository
{
    public interface IWorkflowItemRepository : IRepository<WorkflowItem>
    {
        Task<List<WorkFlowItemQuery>> GetWorkFlowItemByUser(string email);
    }
    public class WorkflowItemRepository : RepositoryBase<WorkflowItem>, IWorkflowItemRepository
    {
        public WorkflowItemRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task<List<WorkFlowItemQuery>> GetWorkFlowItemByUser(string email) 
        {
            var data = await DataContext.WorkFlowItemQuery.FromSqlRaw("internals.GspGetWorkFlowItemsByUser @p0", new SqlParameter("@p0", email)).ToListAsync();
            return data;
        }
    }

}