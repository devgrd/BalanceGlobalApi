
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

    public interface IFlujosService
    {
        Task<ApiResponse> CreateFlujos(FlujosModel FlujosModel, string userName);
        Task<ApiResponse> UpdateFlujos(FlujosModel FlujosModel, string userName);
        Task<ApiResponse> DeleteFlujos(int id, string userName);
        Task<ApiResponse> ReadFlujos(int id);
        Task<ApiResponse> ReadFlujosByPeriodos(int IdPeriodos);
    }

    public class FlujosService : IFlujosService
    {
        private readonly IFlujosRepository _repository;
        private readonly IMapper _mapper;

        public FlujosService(IFlujosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD
        
        public async Task<ApiResponse> ReadFlujosByPeriodos(int IdPeriodos)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodos);
                var result = _mapper.Map<List<FlujosModel>>(data);

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

        public async Task<ApiResponse> CreateFlujos(FlujosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Flujos>(model);
                await _repository.AddAsync(result, userName);
                model.IdFlujos = result.IdFlujos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateFlujos(FlujosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdFlujos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Flujos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteFlujos(int id, string userName)
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

        public async Task<ApiResponse> ReadFlujos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<FlujosModel>(model);

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

