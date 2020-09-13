using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceGlobal.Repository
{
    public interface IPeriodoRepository : IRepository<Periodos> 
    { 
    
    }
    public class PeriodoRepository : RepositoryBase<Periodos>, IPeriodoRepository
    {
        public PeriodoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }
}
