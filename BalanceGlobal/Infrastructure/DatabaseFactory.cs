
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Infrastructure;
using System.Configuration;
using BalanceGlobal.Database.Context;

namespace BalanceGlobal.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private BalanceGlobalContext balanceGlobalContext;

        public DatabaseFactory(BalanceGlobalContext adfDscdesContext)
        {
            this.balanceGlobalContext = adfDscdesContext;
        }

        public Db GetContext<Db>() where Db : DbContext
        {
            if (typeof(Db).Equals(typeof(BalanceGlobalContext)))
            {
                return balanceGlobalContext as Db;
            }
            else
            {
                return null;
            }          
        }


        protected override void DisposeCore()
        {
            if (balanceGlobalContext != null) balanceGlobalContext.Dispose();
        }

    }
}
