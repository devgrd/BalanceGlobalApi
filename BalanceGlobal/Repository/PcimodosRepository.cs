using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IPcimodosRepository : IRepository<Pcimodos>
    {

    }
    public class PcimodosRepository : RepositoryBase<Pcimodos>, IPcimodosRepository
    {
        public PcimodosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}