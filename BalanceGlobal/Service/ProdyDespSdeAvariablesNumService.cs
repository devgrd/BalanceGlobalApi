
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

    public interface IProdyDespSdeAvariablesNumService
    {
        Task<ApiResponse> CreateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel ProdyDespSdeAvariablesNumModel, string userName);
        Task<ApiResponse> ReadProdyDespSdeAvariablesNum();
        Task<ApiResponse> UpdateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel ProdyDespSdeAvariablesNumModel, string userName);
        Task<ApiResponse> DeleteProdyDespSdeAvariablesNum(int id, string userName);
        Task<ApiResponse> ReadProdyDespSdeAvariablesNum(int id);
    }

    public class ProdyDespSdeAvariablesNumService : IProdyDespSdeAvariablesNumService
    {
        private readonly IProdyDespSdeAvariablesNumRepository _repository;
        private readonly IMapper _mapper;

        public ProdyDespSdeAvariablesNumService(IProdyDespSdeAvariablesNumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ProdyDespSdeAvariablesNum>(model);
                await _repository.AddAsync(result, userName);
                model.IdProdyDespSdeAvariablesNum = result.IdProdyDespSdeAvariablesNum;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadProdyDespSdeAvariablesNum()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ProdyDespSdeAvariablesNumModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdProdyDespSdeAvariablesNum);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ProdyDespSdeAvariablesNum>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteProdyDespSdeAvariablesNum(int id, string userName)
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

        public async Task<ApiResponse> ReadProdyDespSdeAvariablesNum(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ProdyDespSdeAvariablesNumModel>(model);

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

