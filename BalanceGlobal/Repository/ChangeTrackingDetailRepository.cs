using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BalanceGlobal.Repository
{
    public interface IChangeTrackingDetailRepository : IRepository<ChangeTrackingDetail>
    {
        Task<List<ChangeTrackingDetail>> GetChangeTrackingDetails(string table, DateTime from, DateTime to);
    }
    public class ChangeTrackingDetailRepository : RepositoryBase<ChangeTrackingDetail>, IChangeTrackingDetailRepository
    {
        public ChangeTrackingDetailRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task<List<ChangeTrackingDetail>> GetChangeTrackingDetails(string table, DateTime from, DateTime to) 
        {
            var results = await DataContext.ChangeTrackingHeader
                          .Where(x => x.TableName == table
                              && x.TransactionDate > @from
                              && x.TransactionDate < to)
                          .Select(x => x.ChangeTrackingDetail).FirstOrDefaultAsync();

            return results.ToList();
        }
    }
}