
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

    public interface IDetallePerfilService
    {
        Task<ApiResponse> CreateDetallePerfil(DetallePerfilModel DetallePerfilModel, string userName);
        Task<ApiResponse> ReadDetallePerfil();
        Task<ApiResponse> UpdateDetallePerfil(DetallePerfilModel DetallePerfilModel, string userName);
        Task<ApiResponse> DeleteDetallePerfil(int id, string userName);
        Task<ApiResponse> ReadDetallePerfil(int id);
    }

    public class DetallePerfilService : IDetallePerfilService
    {
        private readonly IDetallePerfilRepository _repository;
        private readonly IMapper _mapper;

        public DetallePerfilService(IDetallePerfilRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateDetallePerfil(DetallePerfilModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<DetallePerfil>(model);
                await _repository.AddAsync(result, userName);
                model.IdDetallePerfil = result.IdDetallePerfil;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadDetallePerfil()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<DetallePerfilModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateDetallePerfil(DetallePerfilModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdDetallePerfil);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DetallePerfil>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteDetallePerfil(int id, string userName)
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

        public async Task<ApiResponse> ReadDetallePerfil(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DetallePerfilModel>(model);

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

