using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImpregnacionSistemaRefRepository : IRepository<ImpregnacionSistemaRef>
    {

    }
    public class ImpregnacionSistemaRefRepository : RepositoryBase<ImpregnacionSistemaRef>, IImpregnacionSistemaRefRepository
    {
        public ImpregnacionSistemaRefRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}