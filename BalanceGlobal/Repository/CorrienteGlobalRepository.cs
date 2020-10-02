using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICorrienteGlobalRepository : IRepository<CorrienteGlobal>
    {

    }
    public class CorrienteGlobalRepository : RepositoryBase<CorrienteGlobal>, ICorrienteGlobalRepository
    {
        public CorrienteGlobalRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}