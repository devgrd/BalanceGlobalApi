
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

    public interface ITipoInfraestructurasService
    {
        Task<ApiResponse> CreateTipoInfraestructuras(TipoInfraestructurasModel TipoInfraestructurasModel, string userName);
        Task<ApiResponse> ReadTipoInfraestructuras();
        Task<ApiResponse> UpdateTipoInfraestructuras(TipoInfraestructurasModel TipoInfraestructurasModel, string userName);
        Task<ApiResponse> DeleteTipoInfraestructuras(int id, string userName);
        Task<ApiResponse> ReadTipoInfraestructuras(int id);
    }

    public class TipoInfraestructurasService : ITipoInfraestructurasService
    {
        private readonly ITipoInfraestructurasRepository _repository;
        private readonly IMapper _mapper;

        public TipoInfraestructurasService(ITipoInfraestructurasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTipoInfraestructuras(TipoInfraestructurasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TipoInfraestructuras>(model);
                await _repository.AddAsync(result, userName);
                model.IdTipoInfraestructuras = result.IdTipoInfraestructuras;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTipoInfraestructuras()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TipoInfraestructurasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTipoInfraestructuras(TipoInfraestructurasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTipoInfraestructuras);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoInfraestructuras>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTipoInfraestructuras(int id, string userName)
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

        public async Task<ApiResponse> ReadTipoInfraestructuras(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoInfraestructurasModel>(model);

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

