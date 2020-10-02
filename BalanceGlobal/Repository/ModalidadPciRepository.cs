using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IModalidadPciRepository : IRepository<ModalidadPci>
    {

    }
    public class ModalidadPciRepository : RepositoryBase<ModalidadPci>, IModalidadPciRepository
    {
        public ModalidadPciRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}