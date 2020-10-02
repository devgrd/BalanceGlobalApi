using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IDescargaPlataformasRepository : IRepository<DescargaPlataformas>
    {

    }
    public class DescargaPlataformasRepository : RepositoryBase<DescargaPlataformas>, IDescargaPlataformasRepository
    {
        public DescargaPlataformasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}