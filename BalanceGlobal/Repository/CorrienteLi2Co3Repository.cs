using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICorrienteLi2Co3Repository : IRepository<CorrienteLi2Co3>
    {

    }
    public class CorrienteLi2Co3Repository : RepositoryBase<CorrienteLi2Co3>, ICorrienteLi2Co3Repository
    {
        public CorrienteLi2Co3Repository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}