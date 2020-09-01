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
    public class PeriodoReposirory : RepositoryBase<Periodos>, IPeriodoRepository
    {
        public PeriodoReposirory(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {

        }
    }
}
