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

        protected BalanceGlobalContext DataContext { get; set; }
        //private readonly DbQuery<T> dbquery;
        private readonly DbSet<T> dbset;

        protected RepositoryBase(BalanceGlobalContext dataContext)
        {
            DataContext = dataContext;
            dbset = DataContext.Set<T>();
        }


        public virtual async Task<IEnumerable<T>> GetWithStoredProcedureAsync(string spName, params object[] prms)
        {
            var result = await dbset.FromSqlRaw<T>(spName, prms).ToListAsync();
            return result;
        }

        public virtual async Task<T> GetById(object id)
        {
            var entity = await dbset.FindAsync(id);
            DataContext.Entry(entity).State = EntityState.Detached;

            return entity;
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

        public async Task AddAsync(T entity, string userName)
        {
            await dbset.AddAsync(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(object id, string userName)
        {
            var entity = await dbset.FindAsync(id);
            dbset.Remove(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity, string userName)
        {
            dbset.Update(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync(string valorSesion)
        {
            using (var scope = await DataContext.Database.BeginTransactionAsync())
            {
                await SetUserContext(valorSesion);
                await DataContext.SaveChangesAsync();
                await scope.CommitAsync();
            }
        }

        protected async Task SetUserContext(string valorSesion)
        {
            var idParam = new SqlParameter("@valor_sesion ", valorSesion);
            await DataContext.Database.ExecuteSqlRawAsync("dbo.spSistema_ConfiguracionDeSesion_SetContextInfo @valor_sesion", idParam);
        }
    }
}
