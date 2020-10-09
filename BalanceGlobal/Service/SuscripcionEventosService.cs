
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

    public interface ISuscripcionEventosService
    {
        Task<ApiResponse> CreateSuscripcionEventos(SuscripcionEventosModel SuscripcionEventosModel, string userName);
        Task<ApiResponse> ReadSuscripcionEventos();
        Task<ApiResponse> UpdateSuscripcionEventos(SuscripcionEventosModel SuscripcionEventosModel, string userName);
        Task<ApiResponse> DeleteSuscripcionEventos(int id, string userName);
        Task<ApiResponse> ReadSuscripcionEventos(int id);
    }

    public class SuscripcionEventosService : ISuscripcionEventosService
    {
        private readonly ISuscripcionEventosRepository _repository;
        private readonly IMapper _mapper;

        public SuscripcionEventosService(ISuscripcionEventosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSuscripcionEventos(SuscripcionEventosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<SuscripcionEventos>(model);
                await _repository.AddAsync(result, userName);
                model.IdSuscripcionEventos = result.IdSuscripcionEventos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSuscripcionEventos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<SuscripcionEventosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSuscripcionEventos(SuscripcionEventosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSuscripcionEventos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SuscripcionEventos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSuscripcionEventos(int id, string userName)
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

        public async Task<ApiResponse> ReadSuscripcionEventos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SuscripcionEventosModel>(model);

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

