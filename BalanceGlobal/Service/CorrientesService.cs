
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

    public interface ICorrientesService
    {
        Task<ApiResponse> CreateCorrientes(CorrientesModel CorrientesModel, string userName);
        Task<ApiResponse> ReadCorrientes();
        Task<ApiResponse> UpdateCorrientes(CorrientesModel CorrientesModel, string userName);
        Task<ApiResponse> DeleteCorrientes(int id, string userName);
        Task<ApiResponse> ReadCorrientes(int id);
    }

    public class CorrientesService : ICorrientesService
    {
        private readonly ICorrientesRepository _repository;
        private readonly IMapper _mapper;

        public CorrientesService(ICorrientesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCorrientes(CorrientesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Corrientes>(model);
                await _repository.AddAsync(result, userName);
                model.IdCorrientes = result.IdCorrientes;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCorrientes()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CorrientesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCorrientes(CorrientesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCorrientes);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Corrientes>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCorrientes(int id, string userName)
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

        public async Task<ApiResponse> ReadCorrientes(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrientesModel>(model);

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

