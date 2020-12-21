using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WebJobGspPueblaTablaReporteBalance
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                string connectionString = "Server=sqm-sql-srv.database.windows.net;Database=BalanceGlobal_des;User id=geovalidata;Password=geova1C2f3S@12@;";

                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand("balance.GspPueblaTablaReporteBalance", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                command.Parameters.Add(new SqlParameter("@uid", SqlDbType.UniqueIdentifier));
                command.Parameters["@uid"].Value = args.Length == 0 ? Guid.NewGuid() : Guid.Parse(args[0]);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }       
        }
    }
}
