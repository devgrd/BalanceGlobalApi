using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IQuimicaPlataformasRepository : IRepository<QuimicaPlataformas>
    {

    }
    public class QuimicaPlataformasRepository : RepositoryBase<QuimicaPlataformas>, IQuimicaPlataformasRepository
    {
        public QuimicaPlataformasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}