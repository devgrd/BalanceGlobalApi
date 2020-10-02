using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsumoAguaRepository : IRepository<ConsumoAgua>
    {

    }
    public class ConsumoAguaRepository : RepositoryBase<ConsumoAgua>, IConsumoAguaRepository
    {
        public ConsumoAguaRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}