using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BalanceGlobal.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //T GetById(string id);
        //T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IEnumerable<T> GetWithStoredProcedure(string spName, params object[] prms);
        //void Add(T entity);
        //void Update(T entity);
        //void Delete(object id);
    }
}
