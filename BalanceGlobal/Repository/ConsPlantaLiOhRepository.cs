using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IConsPlantaLiOhRepository : IRepository<ConsPlantaLiOh>
    {

    }
    public class ConsPlantaLiOhRepository : RepositoryBase<ConsPlantaLiOh>, IConsPlantaLiOhRepository
    {
        public ConsPlantaLiOhRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}