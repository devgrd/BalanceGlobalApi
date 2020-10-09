
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

    public interface ITiposInventarioService
    {
        Task<ApiResponse> CreateTiposInventario(TiposInventarioModel TiposInventarioModel, string userName);
        Task<ApiResponse> ReadTiposInventario();
        Task<ApiResponse> UpdateTiposInventario(TiposInventarioModel TiposInventarioModel, string userName);
        Task<ApiResponse> DeleteTiposInventario(int id, string userName);
        Task<ApiResponse> ReadTiposInventario(int id);
    }

    public class TiposInventarioService : ITiposInventarioService
    {
        private readonly ITiposInventarioRepository _repository;
        private readonly IMapper _mapper;

        public TiposInventarioService(ITiposInventarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTiposInventario(TiposInventarioModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TiposInventario>(model);
                await _repository.AddAsync(result, userName);
                model.IdTiposInventario = result.IdTiposInventario;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTiposInventario()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TiposInventarioModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTiposInventario(TiposInventarioModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTiposInventario);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TiposInventario>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTiposInventario(int id, string userName)
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

        public async Task<ApiResponse> ReadTiposInventario(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TiposInventarioModel>(model);

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

