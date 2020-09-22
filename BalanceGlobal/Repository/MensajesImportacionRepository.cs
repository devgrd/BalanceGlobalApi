using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IMensajesImportacionRepository : IRepository<MensajesImportacion>
    {

    }
    public class MensajesImportacionRepository : RepositoryBase<MensajesImportacion>, IMensajesImportacionRepository
    {
        public MensajesImportacionRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}