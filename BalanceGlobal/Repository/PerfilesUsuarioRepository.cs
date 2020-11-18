using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace BalanceGlobal.Repository
{
    public interface IPerfilesUsuarioRepository : IRepository<PerfilesUsuario>
    {
        Task UpdatePerfilesUsuarioDetalle(int id, List<DetallePerfil> detallePerfilModel, string userName);
    }
    public class PerfilesUsuarioRepository : RepositoryBase<PerfilesUsuario>, IPerfilesUsuarioRepository
    {
        public PerfilesUsuarioRepository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {

        }

        public async Task UpdatePerfilesUsuarioDetalle(int id, List<DetallePerfil> detallePerfilModel, string userName)
        {
            using (var transaction = await DataContext.Database.BeginTransactionAsync())
            {

                try
                {
                    var del = DataContext.DetallePerfil.Where(x => x.IdPerfilUsuario == id);
                    DataContext.RemoveRange(del);

                    await DataContext.AddRangeAsync(detallePerfilModel);
                    await SetUserContext(userName);

                    await DataContext.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }
    }

}