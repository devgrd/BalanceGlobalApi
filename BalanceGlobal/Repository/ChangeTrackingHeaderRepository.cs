using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BalanceGlobal.Repository
{
    public interface IChangeTrackingHeaderRepository : IRepository<ChangeTrackingHeader>
    {
        Task<List<ChangeTrackingHeader>> GetChangeTrackingHeader(string table, DateTime from, DateTime to);
    }
    public class ChangeTrackingHeaderRepository : RepositoryBase<ChangeTrackingHeader>, IChangeTrackingHeaderRepository
    {
        public ChangeTrackingHeaderRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task<List<ChangeTrackingHeader>> GetChangeTrackingHeader(string table, DateTime from, DateTime to)
        {
            var results =  await DataContext.ChangeTrackingHeader
                          .Where(x => x.TableName == table 
                              && x.TransactionDate > @from
                              && x.TransactionDate < to).ToListAsync();
            return results;
        }
    }
}