
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

    public interface IEvaporacionInfiltracionService
    {
        Task<ApiResponse> CreateEvaporacionInfiltracion(EvaporacionInfiltracionModel EvaporacionInfiltracionModel, string userName);
        Task<ApiResponse> ReadEvaporacionInfiltracion();
        Task<ApiResponse> UpdateEvaporacionInfiltracion(EvaporacionInfiltracionModel EvaporacionInfiltracionModel, string userName);
        Task<ApiResponse> DeleteEvaporacionInfiltracion(int id, string userName);
        Task<ApiResponse> ReadEvaporacionInfiltracion(int id);
    }

    public class EvaporacionInfiltracionService : IEvaporacionInfiltracionService
    {
        private readonly IEvaporacionInfiltracionRepository _repository;
        private readonly IMapper _mapper;

        public EvaporacionInfiltracionService(IEvaporacionInfiltracionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateEvaporacionInfiltracion(EvaporacionInfiltracionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<EvaporacionInfiltracion>(model);
                await _repository.AddAsync(result, userName);
                model.IdEvaporacionInfiltracion = result.IdEvaporacionInfiltracion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadEvaporacionInfiltracion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<EvaporacionInfiltracionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateEvaporacionInfiltracion(EvaporacionInfiltracionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdEvaporacionInfiltracion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<EvaporacionInfiltracion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteEvaporacionInfiltracion(int id, string userName)
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

        public async Task<ApiResponse> ReadEvaporacionInfiltracion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<EvaporacionInfiltracionModel>(model);

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

