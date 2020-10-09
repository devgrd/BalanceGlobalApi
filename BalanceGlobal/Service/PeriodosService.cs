
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

    public interface IPeriodosService
    {
        Task<ApiResponse> CreatePeriodos(PeriodosModel PeriodosModel, string userName);
        Task<ApiResponse> ReadPeriodos();
        Task<ApiResponse> UpdatePeriodos(PeriodosModel PeriodosModel, string userName);
        Task<ApiResponse> DeletePeriodos(int id, string userName);
        Task<ApiResponse> ReadPeriodos(int id);
    }

    public class PeriodosService : IPeriodosService
    {
        private readonly IPeriodosRepository _repository;
        private readonly IMapper _mapper;

        public PeriodosService(IPeriodosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePeriodos(PeriodosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Periodos>(model);
                await _repository.AddAsync(result, userName);
                model.IdPeriodos = result.IdPeriodos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPeriodos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PeriodosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdatePeriodos(PeriodosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPeriodos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Periodos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePeriodos(int id, string userName)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                await _repository.RemoveAsync(id, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPeriodos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PeriodosModel>(model);

                return new ApiResponse(result, 200);

            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        #endregion

    }
}

