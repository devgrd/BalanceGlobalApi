using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface ICategoriaConsumoAguaRepository : IRepository<CategoriaConsumoAgua>
    {

    }
    public class CategoriaConsumoAguaRepository : RepositoryBase<CategoriaConsumoAgua>, ICategoriaConsumoAguaRepository
    {
        public CategoriaConsumoAguaRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}