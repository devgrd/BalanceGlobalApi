﻿using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceGlobal.Repository
{

    public interface ISubSistemasRepository : IRepository<Subsistemas>
    {

    }
    public class SubSistemasRepository : RepositoryBase<Subsistemas>, ISubSistemasRepository
    {
        public SubSistemasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }
}
