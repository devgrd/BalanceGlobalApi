using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ITransSistemasCosechasRepository : IRepository<TransSistemasCosechas>
    {

    }
    public class TransSistemasCosechasRepository : RepositoryBase<TransSistemasCosechas>, ITransSistemasCosechasRepository
    {
        public TransSistemasCosechasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}