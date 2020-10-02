using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IExtraccionAguaRepository : IRepository<ExtraccionAgua>
    {

    }
    public class ExtraccionAguaRepository : RepositoryBase<ExtraccionAgua>, IExtraccionAguaRepository
    {
        public ExtraccionAguaRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}