using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICargaPlataformasRepository : IRepository<CargaPlataformas>
    {

    }
    public class CargaPlataformasRepository : RepositoryBase<CargaPlataformas>, ICargaPlataformasRepository
    {
        public CargaPlataformasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}