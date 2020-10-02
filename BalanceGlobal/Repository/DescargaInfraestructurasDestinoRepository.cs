using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IDescargaInfraestructurasDestinoRepository : IRepository<DescargaInfraestructurasDestino>
    {

    }
    public class DescargaInfraestructurasDestinoRepository : RepositoryBase<DescargaInfraestructurasDestino>, IDescargaInfraestructurasDestinoRepository
    {
        public DescargaInfraestructurasDestinoRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}