using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPermeabilidadRepository : IRepository<Permeabilidad>
    {

    }
    public class PermeabilidadRepository : RepositoryBase<Permeabilidad>, IPermeabilidadRepository
    {
        public PermeabilidadRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}