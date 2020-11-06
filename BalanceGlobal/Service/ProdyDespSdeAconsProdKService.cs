
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

    public interface IProdyDespSdeAconsProdKService
    {
        Task<ApiResponse> CreateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel ProdyDespSdeAconsProdKModel, string userName);
        Task<ApiResponse> ReadProdyDespSdeAconsProdKByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel ProdyDespSdeAconsProdKModel, string userName);
        Task<ApiResponse> DeleteProdyDespSdeAconsProdK(int id, string userName);
        Task<ApiResponse> ReadProdyDespSdeAconsProdK(int id);
    }

    public class ProdyDespSdeAconsProdKService : IProdyDespSdeAconsProdKService
    {
        private readonly IProdyDespSdeAconsProdKRepository _repository;
        private readonly IMapper _mapper;

        public ProdyDespSdeAconsProdKService(IProdyDespSdeAconsProdKRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ProdyDespSdeAconsProdK>(model);
                await _repository.AddAsync(result, userName);
                model.IdProdyDespSdeAconsProdK = result.IdProdyDespSdeAconsProdK;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadProdyDespSdeAconsProdKByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ProdyDespSdeAconsProdKModel>>(data);

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

        public async Task<ApiResponse> UpdateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdProdyDespSdeAconsProdK);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ProdyDespSdeAconsProdK>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteProdyDespSdeAconsProdK(int id, string userName)
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

        public async Task<ApiResponse> ReadProdyDespSdeAconsProdK(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ProdyDespSdeAconsProdKModel>(model);

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

