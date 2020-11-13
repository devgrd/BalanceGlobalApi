
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

    public interface IMensajesService
    {
        Task<ApiResponse> CreateMensajes(MensajesModel MensajesModel, string userName);
        Task<ApiResponse> ReadMensajes();
        Task<ApiResponse> UpdateMensajes(MensajesModel MensajesModel, string userName);
        Task<ApiResponse> DeleteMensajes(int id, string userName);
        Task<ApiResponse> ReadMensajes(int id);
    }

    public class MensajesService : IMensajesService
    {
        private readonly IMensajesRepository _repository;
        private readonly IMapper _mapper;

        public MensajesService(IMensajesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateMensajes(MensajesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Mensajes>(model);
                await _repository.AddAsync(result, userName);
                model.IdMensajes = result.IdMensajes;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadMensajes()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<MensajesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateMensajes(MensajesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdMensajes);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Mensajes>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteMensajes(int id, string userName)
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

        public async Task<ApiResponse> ReadMensajes(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<MensajesModel>(model);

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
