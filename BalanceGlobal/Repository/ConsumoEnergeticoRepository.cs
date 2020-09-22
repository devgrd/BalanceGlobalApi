using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsumoEnergeticoRepository : IRepository<ConsumoEnergetico>
    {

    }
    public class ConsumoEnergeticoRepository : RepositoryBase<ConsumoEnergetico>, IConsumoEnergeticoRepository
    {
        public ConsumoEnergeticoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}