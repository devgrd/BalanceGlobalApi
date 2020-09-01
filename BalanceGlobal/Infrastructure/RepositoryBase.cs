using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Database.Context;

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

        public virtual IEnumerable<T> GetWithStoredProcedure(string spName, params object[] prms)
        {
            try
            {
                var result = dbset.FromSqlRaw<T>(spName, prms);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.AsNoTracking().ToList();
        }


        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).AsNoTracking().ToList();
        }

        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
    }
}
