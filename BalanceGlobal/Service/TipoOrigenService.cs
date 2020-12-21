
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

    public interface ITipoOrigenService
    {
        Task<ApiResponse> CreateTipoOrigen(TipoOrigenModel TipoOrigenModel, string userName);
        Task<ApiResponse> ReadTipoOrigen();
        Task<ApiResponse> UpdateTipoOrigen(TipoOrigenModel TipoOrigenModel, string userName);
        Task<ApiResponse> DeleteTipoOrigen(int id, string userName);
        Task<ApiResponse> ReadTipoOrigen(int id);
    }

    public class TipoOrigenService : ITipoOrigenService
    {
        private readonly ITipoOrigenRepository _repository;
        private readonly IMapper _mapper;

        public TipoOrigenService(ITipoOrigenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTipoOrigen(TipoOrigenModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TipoOrigen>(model);
                await _repository.AddAsync(result, userName);
                model.IdTipoOrigen = result.IdTipoOrigen;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTipoOrigen()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TipoOrigenModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTipoOrigen(TipoOrigenModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTipoOrigen);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoOrigen>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTipoOrigen(int id, string userName)
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

        public async Task<ApiResponse> ReadTipoOrigen(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoOrigenModel>(model);

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

