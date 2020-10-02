using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsLitioLiCo3mensualRepository : IRepository<ConsLitioLiCo3mensual>
    {

    }
    public class ConsLitioLiCo3mensualRepository : RepositoryBase<ConsLitioLiCo3mensual>, IConsLitioLiCo3mensualRepository
    {
        public ConsLitioLiCo3mensualRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}