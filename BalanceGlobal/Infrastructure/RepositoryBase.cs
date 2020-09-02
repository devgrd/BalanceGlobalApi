using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Database.Context;
using System.Threading.Tasks;

namespace BalanceGlobal.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private BalanceGlobalContext dataContext;
        //private readonly DbQuery<T> dbquery;
        private readonly DbSet<T> dbset;

        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected BalanceGlobalContext DataContext
        {
            get
            {
                var db = dataContext ?? (dataContext = DatabaseFactory.GetContext<BalanceGlobalContext>());
                db.Database.SetCommandTimeout(600);
                return db;
            }
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
            await dataContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(object id)
        {
            var entity = await dbset.FindAsync(id);
            dbset.Remove(entity);
            await dataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dbset.Update(entity);
            await dataContext.SaveChangesAsync();
        }
    }
}
