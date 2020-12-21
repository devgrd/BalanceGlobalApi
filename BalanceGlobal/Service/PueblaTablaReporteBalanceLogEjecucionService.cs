
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
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPueblaTablaReporteBalanceLogEjecucionService
    {
        //Task<ApiResponse> CreatePueblaTablaReporteBalanceLogEjecucion(PueblaTablaReporteBalanceLogEjecucionModel PueblaTablaReporteBalanceLogEjecucionModel, string userName);
        Task<ApiResponse> ReadPueblaTablaReporteBalanceLogEjecucion();
        //Task<ApiResponse> UpdatePueblaTablaReporteBalanceLogEjecucion(PueblaTablaReporteBalanceLogEjecucionModel PueblaTablaReporteBalanceLogEjecucionModel, string userName);
        //Task<ApiResponse> DeletePueblaTablaReporteBalanceLogEjecucion(int id, string userName);
        //Task<ApiResponse> ReadPueblaTablaReporteBalanceLogEjecucion(int id);
    }

    public class PueblaTablaReporteBalanceLogEjecucionService : IPueblaTablaReporteBalanceLogEjecucionService
    {
        private readonly IPueblaTablaReporteBalanceLogEjecucionRepository _repository;
        private readonly IMapper _mapper;

        public PueblaTablaReporteBalanceLogEjecucionService(IPueblaTablaReporteBalanceLogEjecucionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        //public async Task<ApiResponse> CreatePueblaTablaReporteBalanceLogEjecucion(PueblaTablaReporteBalanceLogEjecucionModel model, string userName)
        //{
        //    try
        //    {
        //        var result = _mapper.Map<PueblaTablaReporteBalanceLogEjecucion>(model);
        //        await _repository.AddAsync(result, userName);
        //        model.IdPueblaTablaReporteBalanceLogEjecucion = result.IdPueblaTablaReporteBalanceLogEjecucion;

        //        return new ApiResponse(model, 200);
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        return new ApiResponse(ex.GetBaseException().Message, 409);
        //    }
        //}

        public async Task<ApiResponse> ReadPueblaTablaReporteBalanceLogEjecucion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PueblaTablaReporteBalanceLogEjecucionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        //public async Task<ApiResponse> UpdatePueblaTablaReporteBalanceLogEjecucion(PueblaTablaReporteBalanceLogEjecucionModel model, string userName)
        //{
        //    try
        //    {
        //        var _model = await _repository.GetById(model.IdPueblaTablaReporteBalanceLogEjecucion);

        //        if (_model == null)
        //        {
        //            return new ApiResponse("Not Found", 404);
        //        }

        //        var result = _mapper.Map<PueblaTablaReporteBalanceLogEjecucion>(model);
        //        await _repository.UpdateAsync(result, userName);

        //        return new ApiResponse("Ok", 200);
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        return new ApiResponse(ex.GetBaseException().Message, 409);
        //    }
        //}

        //public async Task<ApiResponse> DeletePueblaTablaReporteBalanceLogEjecucion(int id, string userName)
        //{
        //    try
        //    {
        //        var model = await _repository.GetById(id);

        //        if (model == null)
        //        {
        //            return new ApiResponse("Not Found", 404);
        //        }

        //        await _repository.RemoveAsync(id, userName);

        //        return new ApiResponse("Ok", 200);
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        return new ApiResponse(ex.GetBaseException().Message, 409);
        //    }
        //}

        //public async Task<ApiResponse> ReadPueblaTablaReporteBalanceLogEjecucion(int id)
        //{
        //    try
        //    {
        //        var model = await _repository.GetById(id);

        //        if (model == null)
        //        {
        //            return new ApiResponse("Not Found", 404);
        //        }

        //        var result = _mapper.Map<PueblaTablaReporteBalanceLogEjecucionModel>(model);

        //        return new ApiResponse(result, 200);

        //    }
        //    catch (Exception ex)
        //    {
        //        return new ApiResponse(ex.GetBaseException().Message, 409);
        //    }
        //}

        #endregion

    }
}

