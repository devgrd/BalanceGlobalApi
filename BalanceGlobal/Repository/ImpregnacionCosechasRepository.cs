using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImpregnacionCosechasRepository : IRepository<ImpregnacionCosechas>
    {

    }
    public class ImpregnacionCosechasRepository : RepositoryBase<ImpregnacionCosechas>, IImpregnacionCosechasRepository
    {
        public ImpregnacionCosechasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}