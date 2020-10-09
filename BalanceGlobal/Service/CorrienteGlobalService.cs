
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

    public interface ICorrienteGlobalService
    {
        Task<ApiResponse> CreateCorrienteGlobal(CorrienteGlobalModel CorrienteGlobalModel, string userName);
        Task<ApiResponse> ReadCorrienteGlobal();
        Task<ApiResponse> UpdateCorrienteGlobal(CorrienteGlobalModel CorrienteGlobalModel, string userName);
        Task<ApiResponse> DeleteCorrienteGlobal(int id, string userName);
        Task<ApiResponse> ReadCorrienteGlobal(int id);
    }

    public class CorrienteGlobalService : ICorrienteGlobalService
    {
        private readonly ICorrienteGlobalRepository _repository;
        private readonly IMapper _mapper;

        public CorrienteGlobalService(ICorrienteGlobalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCorrienteGlobal(CorrienteGlobalModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<CorrienteGlobal>(model);
                await _repository.AddAsync(result, userName);
                model.IdCorrienteGlobal = result.IdCorrienteGlobal;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCorrienteGlobal()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CorrienteGlobalModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCorrienteGlobal(CorrienteGlobalModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCorrienteGlobal);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrienteGlobal>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCorrienteGlobal(int id, string userName)
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

        public async Task<ApiResponse> ReadCorrienteGlobal(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrienteGlobalModel>(model);

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

