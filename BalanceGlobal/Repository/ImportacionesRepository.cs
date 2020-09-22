using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{
    public interface IImportacionesRepository : IRepository<Importaciones>
    {

    }
    public class ImportacionesRepository : RepositoryBase<Importaciones>, IImportacionesRepository
    {
        public ImportacionesRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }
    }

}