using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IModalidadPlantasRepository : IRepository<ModalidadPlantas>
    {

    }
    public class ModalidadPlantasRepository : RepositoryBase<ModalidadPlantas>, IModalidadPlantasRepository
    {
        public ModalidadPlantasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}