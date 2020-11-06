
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

    public interface IConsLi2Co3Service
    {
        Task<ApiResponse> CreateConsLi2Co3(ConsLi2Co3Model ConsLi2Co3Model, string userName);
        Task<ApiResponse> ReadConsLi2Co3ByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateConsLi2Co3(ConsLi2Co3Model ConsLi2Co3Model, string userName);
        Task<ApiResponse> DeleteConsLi2Co3(int id, string userName);
        Task<ApiResponse> ReadConsLi2Co3(int id);
    }

    public class ConsLi2Co3Service : IConsLi2Co3Service
    {
        private readonly IConsLi2Co3Repository _repository;
        private readonly IMapper _mapper;

        public ConsLi2Co3Service(IConsLi2Co3Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsLi2Co3(ConsLi2Co3Model model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsLi2Co3>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsLi2Co3 = result.IdConsLi2Co3;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsLi2Co3ByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsLi2Co3Model>>(data);

                if (result.Count == 0)
                {
                    return new ApiResponse("Not Found", 404);
                }

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateConsLi2Co3(ConsLi2Co3Model model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsLi2Co3);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsLi2Co3>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsLi2Co3(int id, string userName)
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

        public async Task<ApiResponse> ReadConsLi2Co3(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsLi2Co3Model>(model);

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

