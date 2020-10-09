
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

    public interface ICorrienteLi2Co3Service
    {
        Task<ApiResponse> CreateCorrienteLi2Co3(CorrienteLi2Co3Model CorrienteLi2Co3Model, string userName);
        Task<ApiResponse> ReadCorrienteLi2Co3();
        Task<ApiResponse> UpdateCorrienteLi2Co3(CorrienteLi2Co3Model CorrienteLi2Co3Model, string userName);
        Task<ApiResponse> DeleteCorrienteLi2Co3(int id, string userName);
        Task<ApiResponse> ReadCorrienteLi2Co3(int id);
    }

    public class CorrienteLi2Co3Service : ICorrienteLi2Co3Service
    {
        private readonly ICorrienteLi2Co3Repository _repository;
        private readonly IMapper _mapper;

        public CorrienteLi2Co3Service(ICorrienteLi2Co3Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCorrienteLi2Co3(CorrienteLi2Co3Model model, string userName)
        {
            try
            {
                var result = _mapper.Map<CorrienteLi2Co3>(model);
                await _repository.AddAsync(result, userName);
                model.IdCorrienteLi2Co3 = result.IdCorrienteLi2Co3;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCorrienteLi2Co3()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CorrienteLi2Co3Model>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCorrienteLi2Co3(CorrienteLi2Co3Model model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCorrienteLi2Co3);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrienteLi2Co3>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCorrienteLi2Co3(int id, string userName)
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

        public async Task<ApiResponse> ReadCorrienteLi2Co3(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrienteLi2Co3Model>(model);

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

