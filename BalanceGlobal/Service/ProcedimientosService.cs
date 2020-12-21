
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using BalanceGlobal.Response;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IProcedimientosService
    {
        Task<ApiResponse> GspPueblaTablaReporteBalance(string userName);
        Task<ApiResponse> GspGetUltimosPeriodosTablasDatos();
        ApiResponse GspGetUltimosSeisPeriodosTablasDatos();
    }

    public class ProcedimientosService : IProcedimientosService
    {
        private readonly IProcedimientosRepository _repository;

        public ProcedimientosService(IProcedimientosRepository repository)
        {
            _repository = repository;
        }

        #region CRUD

        public async Task<ApiResponse> GspPueblaTablaReporteBalance(string userName)
        {
            try
            {
                await _repository.GspPueblaTablaReporteBalance(userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> GspGetUltimosPeriodosTablasDatos()
        {
            try
            {
                var data = await _repository.GspGetUltimosPeriodosTablasDatos();
                return new ApiResponse(data, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public ApiResponse GspGetUltimosSeisPeriodosTablasDatos()
        {
            try
            {
                var data = _repository.GetDynamicResult("GspGetUltimosSeisPeriodosTablasDatos").ToList();
                return new ApiResponse(data, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }

        }

        #endregion

        
    }
}

