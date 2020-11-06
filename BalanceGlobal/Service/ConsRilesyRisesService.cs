
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

    public interface IConsRilesyRisesService
    {
        Task<ApiResponse> CreateConsRilesyRises(ConsRilesyRisesModel ConsRilesyRisesModel, string userName);
        Task<ApiResponse> ReadConsRilesyRisesByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateConsRilesyRises(ConsRilesyRisesModel ConsRilesyRisesModel, string userName);
        Task<ApiResponse> DeleteConsRilesyRises(int id, string userName);
        Task<ApiResponse> ReadConsRilesyRises(int id);
    }

    public class ConsRilesyRisesService : IConsRilesyRisesService
    {
        private readonly IConsRilesyRisesRepository _repository;
        private readonly IMapper _mapper;

        public ConsRilesyRisesService(IConsRilesyRisesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsRilesyRises(ConsRilesyRisesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsRilesyRises>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsRilesyRises = result.IdConsRilesyRises;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsRilesyRisesByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsRilesyRisesModel>>(data);

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

        public async Task<ApiResponse> UpdateConsRilesyRises(ConsRilesyRisesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsRilesyRises);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsRilesyRises>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsRilesyRises(int id, string userName)
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

        public async Task<ApiResponse> ReadConsRilesyRises(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsRilesyRisesModel>(model);

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

