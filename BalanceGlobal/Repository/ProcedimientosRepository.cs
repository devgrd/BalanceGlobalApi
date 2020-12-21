using BalanceGlobal.Database.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Database.Queries;
using Microsoft.Data.SqlClient;
using System.Dynamic;

namespace BalanceGlobal.Repository
{
    public interface IProcedimientosRepository
    {
        Task GspPueblaTablaReporteBalance(string userName);
        Task<List<UltimosPeriodosTablasDatos>> GspGetUltimosPeriodosTablasDatos();
        IEnumerable<dynamic> GetDynamicResult(string commandText, params SqlParameter[] parameters);
    }

    public class ProcedimientosRepository : IProcedimientosRepository
    {
        private readonly BalanceGlobalContext _balanceGlobalContext;

        public ProcedimientosRepository(BalanceGlobalContext balanceGlobalContext)
        {
            _balanceGlobalContext = balanceGlobalContext;
        }

        public async Task GspPueblaTablaReporteBalance(string userName) 
        {
            using (var transaction = await _balanceGlobalContext.Database.BeginTransactionAsync())
            {
                try
                {
                    await SetUserContext(userName);
                   
                    await _balanceGlobalContext.Database.ExecuteSqlRawAsync("Balance.GspPueblaTablaReporteBalance");

                    await _balanceGlobalContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }

        public async Task<List<UltimosPeriodosTablasDatos>> GspGetUltimosPeriodosTablasDatos()
        {
            var data = await _balanceGlobalContext.UltimosPeriodosTablasDatos.FromSqlRaw("dbo.GspGetUltimosPeriodosTablasDatos").ToListAsync();
            return data;
        }

        private async Task SetUserContext(string valorSesion)
        {
            var idParam = new SqlParameter("@valor_sesion ", valorSesion);
            await _balanceGlobalContext.Database.ExecuteSqlRawAsync("dbo.spSistema_ConfiguracionDeSesion_SetContextInfo @valor_sesion", idParam);
        }

        public IEnumerable<dynamic> GetDynamicResult(string commandText, params SqlParameter[] parameters)
        {

            var connection = _balanceGlobalContext.Database.GetDbConnection();

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = commandText;
                command.Connection = connection;

                if (parameters?.Length > 0)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }

                using (var dataReader = command.ExecuteReader())
                {
                    var names = new List<string>();

                    if (dataReader.HasRows)
                    {
                        for (var i = 0; i < dataReader.VisibleFieldCount; i++)
                        {
                            names.Add(dataReader.GetName(i));
                        }

                        while (dataReader.Read())
                        {
                            var result = new ExpandoObject() as IDictionary<string, object>;

                            foreach (var name in names)
                            {
                                result.Add(name, dataReader[name]);
                            }

                            yield return result;
                        }
                    }
                }
            }
        }
    } 
}
