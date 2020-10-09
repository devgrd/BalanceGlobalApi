
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

    public interface IPerfilesUsuarioService
    {
        Task<ApiResponse> CreatePerfilesUsuario(PerfilesUsuarioModel PerfilesUsuarioModel, string userName);
        Task<ApiResponse> ReadPerfilesUsuario();
        Task<ApiResponse> UpdatePerfilesUsuario(PerfilesUsuarioModel PerfilesUsuarioModel, string userName);
        Task<ApiResponse> DeletePerfilesUsuario(int id, string userName);
        Task<ApiResponse> ReadPerfilesUsuario(int id);
    }

    public class PerfilesUsuarioService : IPerfilesUsuarioService
    {
        private readonly IPerfilesUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public PerfilesUsuarioService(IPerfilesUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePerfilesUsuario(PerfilesUsuarioModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<PerfilesUsuario>(model);
                await _repository.AddAsync(result, userName);
                model.IdPerfilUsuario = result.IdPerfilUsuario;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPerfilesUsuario()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PerfilesUsuarioModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdatePerfilesUsuario(PerfilesUsuarioModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPerfilUsuario);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PerfilesUsuario>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePerfilesUsuario(int id, string userName)
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

        public async Task<ApiResponse> ReadPerfilesUsuario(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PerfilesUsuarioModel>(model);

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

