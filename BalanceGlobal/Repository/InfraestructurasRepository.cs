using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IInfraestructurasRepository : IRepository<Infraestructuras>
    {

    }
    public class InfraestructurasRepository : RepositoryBase<Infraestructuras>, IInfraestructurasRepository
    {
        public InfraestructurasRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}