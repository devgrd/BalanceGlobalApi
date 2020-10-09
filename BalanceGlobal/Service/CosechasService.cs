
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

    public interface ICosechasService
    {
        Task<ApiResponse> CreateCosechas(CosechasModel CosechasModel, string userName);
        Task<ApiResponse> ReadCosechas();
        Task<ApiResponse> UpdateCosechas(CosechasModel CosechasModel, string userName);
        Task<ApiResponse> DeleteCosechas(int id, string userName);
        Task<ApiResponse> ReadCosechas(int id);
    }

    public class CosechasService : ICosechasService
    {
        private readonly ICosechasRepository _repository;
        private readonly IMapper _mapper;

        public CosechasService(ICosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCosechas(CosechasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Cosechas>(model);
                await _repository.AddAsync(result, userName);
                model.IdCosechas = result.IdCosechas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCosechas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CosechasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCosechas(CosechasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCosechas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Cosechas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCosechas(int id, string userName)
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

        public async Task<ApiResponse> ReadCosechas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CosechasModel>(model);

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

