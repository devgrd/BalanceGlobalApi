
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

    public interface IOperaPozasService
    {
        Task<ApiResponse> CreateOperaPozas(OperaPozasModel OperaPozasModel, string userName);
        Task<ApiResponse> ReadOperaPozas();
        Task<ApiResponse> UpdateOperaPozas(OperaPozasModel OperaPozasModel, string userName);
        Task<ApiResponse> DeleteOperaPozas(int id, string userName);
        Task<ApiResponse> ReadOperaPozas(int id);
    }

    public class OperaPozasService : IOperaPozasService
    {
        private readonly IOperaPozasRepository _repository;
        private readonly IMapper _mapper;

        public OperaPozasService(IOperaPozasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateOperaPozas(OperaPozasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<OperaPozas>(model);
                await _repository.AddAsync(result, userName);
                model.IdOperaPozas = result.IdOperaPozas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadOperaPozas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<OperaPozasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateOperaPozas(OperaPozasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdOperaPozas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<OperaPozas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteOperaPozas(int id, string userName)
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

        public async Task<ApiResponse> ReadOperaPozas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<OperaPozasModel>(model);

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

