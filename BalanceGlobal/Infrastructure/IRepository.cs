using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BalanceGlobal.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(object id);
        //T Get(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetWithStoredProcedureAsync(string spName, params object[] prms);
        Task AddAsync(T entity, string userName);
        Task UpdateAsync(T entity, string userName);
        Task RemoveAsync(object id, string userName);
    }
}
