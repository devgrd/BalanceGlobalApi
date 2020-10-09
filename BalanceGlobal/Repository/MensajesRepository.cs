using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IMensajesRepository : IRepository<Mensajes>
    {

    }
    public class MensajesRepository : RepositoryBase<Mensajes>, IMensajesRepository
    {
        public MensajesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}