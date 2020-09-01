
using Microsoft.EntityFrameworkCore;
using System;

namespace BalanceGlobal.Infrastructure
{
    public interface IDatabaseFactory: IDisposable
    {
        Db GetContext<Db>() where Db : DbContext;
        //ComponentesBioticosContext GetComponentesBioticosContext();
    }
}
