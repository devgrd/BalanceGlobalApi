using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IReservoriosRepository : IRepository<Reservorios>
    {

    }
    public class ReservoriosRepository : RepositoryBase<Reservorios>, IReservoriosRepository
    {
        public ReservoriosRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}