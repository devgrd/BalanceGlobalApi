using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICkmopIivolaPorteoRepository : IRepository<CkmopIivolaPorteo>
    {

    }
    public class CkmopIivolaPorteoRepository : RepositoryBase<CkmopIivolaPorteo>, ICkmopIivolaPorteoRepository
    {
        public CkmopIivolaPorteoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}