
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

    public interface IUsuariosService
    {
        Task<ApiResponse> CreateUsuarios(UsuariosModel UsuariosModel, string userName);
        Task<ApiResponse> ReadUsuarios();
        Task<ApiResponse> UpdateUsuarios(UsuariosModel UsuariosModel, string userName);
        Task<ApiResponse> DeleteUsuarios(int id, string userName);
        Task<ApiResponse> ReadUsuarios(int id);
    }

    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _repository;
        private readonly IMapper _mapper;

        public UsuariosService(IUsuariosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateUsuarios(UsuariosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Usuarios>(model);
                await _repository.AddAsync(result, userName);
                model.IdUsuarios = result.IdUsuarios;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadUsuarios()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<UsuariosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateUsuarios(UsuariosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdUsuarios);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Usuarios>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteUsuarios(int id, string userName)
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

        public async Task<ApiResponse> ReadUsuarios(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<UsuariosModel>(model);

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

