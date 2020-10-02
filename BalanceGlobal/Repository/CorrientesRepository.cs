using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICorrientesRepository : IRepository<Corrientes>
    {

    }
    public class CorrientesRepository : RepositoryBase<Corrientes>, ICorrientesRepository
    {
        public CorrientesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}