
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

    public interface ICorrientesRilesyRisesService
    {
        Task<ApiResponse> CreateCorrientesRilesyRises(CorrientesRilesyRisesModel CorrientesRilesyRisesModel, string userName);
        Task<ApiResponse> ReadCorrientesRilesyRises();
        Task<ApiResponse> UpdateCorrientesRilesyRises(CorrientesRilesyRisesModel CorrientesRilesyRisesModel, string userName);
        Task<ApiResponse> DeleteCorrientesRilesyRises(int id, string userName);
        Task<ApiResponse> ReadCorrientesRilesyRises(int id);
    }

    public class CorrientesRilesyRisesService : ICorrientesRilesyRisesService
    {
        private readonly ICorrientesRilesyRisesRepository _repository;
        private readonly IMapper _mapper;

        public CorrientesRilesyRisesService(ICorrientesRilesyRisesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCorrientesRilesyRises(CorrientesRilesyRisesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<CorrientesRilesyRises>(model);
                await _repository.AddAsync(result, userName);
                model.IdCorrientesRilesyRises = result.IdCorrientesRilesyRises;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCorrientesRilesyRises()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CorrientesRilesyRisesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCorrientesRilesyRises(CorrientesRilesyRisesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCorrientesRilesyRises);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrientesRilesyRises>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCorrientesRilesyRises(int id, string userName)
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

        public async Task<ApiResponse> ReadCorrientesRilesyRises(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrientesRilesyRisesModel>(model);

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

