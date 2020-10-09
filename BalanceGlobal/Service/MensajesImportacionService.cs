
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

    public interface IMensajesImportacionService
    {
        Task<ApiResponse> CreateMensajesImportacion(MensajesImportacionModel MensajesImportacionModel, string userName);
        Task<ApiResponse> ReadMensajesImportacion();
        Task<ApiResponse> UpdateMensajesImportacion(MensajesImportacionModel MensajesImportacionModel, string userName);
        Task<ApiResponse> DeleteMensajesImportacion(int id, string userName);
        Task<ApiResponse> ReadMensajesImportacion(int id);
    }

    public class MensajesImportacionService : IMensajesImportacionService
    {
        private readonly IMensajesImportacionRepository _repository;
        private readonly IMapper _mapper;

        public MensajesImportacionService(IMensajesImportacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateMensajesImportacion(MensajesImportacionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<MensajesImportacion>(model);
                await _repository.AddAsync(result, userName);
                model.IdMensajesImportacion = result.IdMensajesImportacion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadMensajesImportacion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<MensajesImportacionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateMensajesImportacion(MensajesImportacionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdMensajesImportacion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<MensajesImportacion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteMensajesImportacion(int id, string userName)
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

        public async Task<ApiResponse> ReadMensajesImportacion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<MensajesImportacionModel>(model);

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

