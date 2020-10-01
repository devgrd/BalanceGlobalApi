using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Database.Context;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BalanceGlobal.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private BalanceGlobalContext _dataContext;
        //private readonly DbQuery<T> dbquery;
        private readonly DbSet<T> dbset;

        protected RepositoryBase(BalanceGlobalContext dataContext)
        {
            _dataContext = dataContext;
            dbset = _dataContext.Set<T>();
        }


        public virtual async Task<IEnumerable<T>> GetWithStoredProcedureAsync(string spName, params object[] prms)
        {
            var result = await dbset.FromSqlRaw<T>(spName, prms).ToListAsync();
            return result;
        }

        public virtual async Task<T> GetById(string id)
        {
            return await dbset.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where)
        {
            return await dbset.Where(where).ToListAsync();
        }

        public virtual async Task<T> Get(Expression<Func<T, bool>> where)
        {
            return await dbset.Where(where).FirstOrDefaultAsync<T>();
        }

        public async Task AddAsync(T entity)
        {
            await dbset.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(object id)
        {
            var entity = await dbset.FindAsync(id);
            dbset.Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dbset.Update(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync(string valorSesion)
        {
            using (var scope = await _dataContext.Database.BeginTransactionAsync())
            {
                await SetUserContext(valorSesion);
                await _dataContext.SaveChangesAsync();
                await scope.CommitAsync();
            }
        }

        private async Task SetUserContext(string valorSesion)
        {
            var idParam = new SqlParameter("@valor_sesion ", valorSesion);
            await _dataContext.Database.ExecuteSqlRawAsync("dbo.spSistema_ConfiguracionDeSesion_SetContextInfo @valor_sesion", idParam);
        }
    }
}
