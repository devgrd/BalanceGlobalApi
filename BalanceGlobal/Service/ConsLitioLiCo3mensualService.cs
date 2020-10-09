
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

    public interface IConsLitioLiCo3mensualService
    {
        Task<ApiResponse> CreateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel ConsLitioLiCo3mensualModel, string userName);
        Task<ApiResponse> ReadConsLitioLiCo3mensual();
        Task<ApiResponse> UpdateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel ConsLitioLiCo3mensualModel, string userName);
        Task<ApiResponse> DeleteConsLitioLiCo3mensual(int id, string userName);
        Task<ApiResponse> ReadConsLitioLiCo3mensual(int id);
    }

    public class ConsLitioLiCo3mensualService : IConsLitioLiCo3mensualService
    {
        private readonly IConsLitioLiCo3mensualRepository _repository;
        private readonly IMapper _mapper;

        public ConsLitioLiCo3mensualService(IConsLitioLiCo3mensualRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsLitioLiCo3mensual>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsLitioLiCo3mensual = result.IdConsLitioLiCo3mensual;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsLitioLiCo3mensual()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ConsLitioLiCo3mensualModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsLitioLiCo3mensual);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsLitioLiCo3mensual>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsLitioLiCo3mensual(int id, string userName)
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

        public async Task<ApiResponse> ReadConsLitioLiCo3mensual(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsLitioLiCo3mensualModel>(model);

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

