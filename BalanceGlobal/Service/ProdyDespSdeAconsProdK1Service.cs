
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

    public interface IProdyDespSdeAconsProdK1Service
    {
        Task<ApiResponse> CreateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model ProdyDespSdeAconsProdK1Model, string userName);
        Task<ApiResponse> ReadProdyDespSdeAconsProdK1();
        Task<ApiResponse> UpdateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model ProdyDespSdeAconsProdK1Model, string userName);
        Task<ApiResponse> DeleteProdyDespSdeAconsProdK1(int id, string userName);
        Task<ApiResponse> ReadProdyDespSdeAconsProdK1(int id);
    }

    public class ProdyDespSdeAconsProdK1Service : IProdyDespSdeAconsProdK1Service
    {
        private readonly IProdyDespSdeAconsProdK1Repository _repository;
        private readonly IMapper _mapper;

        public ProdyDespSdeAconsProdK1Service(IProdyDespSdeAconsProdK1Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model model, string userName)
        {
            try
            {
                var result = _mapper.Map<ProdyDespSdeAconsProdK1>(model);
                await _repository.AddAsync(result, userName);
                model.IdProdyDespSdeAconsProdK1 = result.IdProdyDespSdeAconsProdK1;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadProdyDespSdeAconsProdK1()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ProdyDespSdeAconsProdK1Model>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdProdyDespSdeAconsProdK1);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ProdyDespSdeAconsProdK1>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteProdyDespSdeAconsProdK1(int id, string userName)
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

        public async Task<ApiResponse> ReadProdyDespSdeAconsProdK1(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ProdyDespSdeAconsProdK1Model>(model);

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

