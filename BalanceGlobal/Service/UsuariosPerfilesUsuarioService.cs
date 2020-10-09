
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

    public interface IUsuariosPerfilesUsuarioService
    {
        Task<ApiResponse> CreateUsuariosPerfilesUsuario(UsuariosPerfilesUsuarioModel UsuariosPerfilesUsuarioModel, string userName);
        Task<ApiResponse> ReadUsuariosPerfilesUsuario();
        Task<ApiResponse> UpdateUsuariosPerfilesUsuario(UsuariosPerfilesUsuarioModel UsuariosPerfilesUsuarioModel, string userName);
        Task<ApiResponse> DeleteUsuariosPerfilesUsuario(int id, string userName);
        Task<ApiResponse> ReadUsuariosPerfilesUsuario(int id);
    }

    public class UsuariosPerfilesUsuarioService : IUsuariosPerfilesUsuarioService
    {
        private readonly IUsuariosPerfilesUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuariosPerfilesUsuarioService(IUsuariosPerfilesUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateUsuariosPerfilesUsuario(UsuariosPerfilesUsuarioModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<UsuariosPerfilesUsuario>(model);
                await _repository.AddAsync(result, userName);
                model.IdUsuariosPerfilesUsuario = result.IdUsuariosPerfilesUsuario;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadUsuariosPerfilesUsuario()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<UsuariosPerfilesUsuarioModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateUsuariosPerfilesUsuario(UsuariosPerfilesUsuarioModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdUsuariosPerfilesUsuario);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<UsuariosPerfilesUsuario>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteUsuariosPerfilesUsuario(int id, string userName)
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

        public async Task<ApiResponse> ReadUsuariosPerfilesUsuario(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<UsuariosPerfilesUsuarioModel>(model);

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

