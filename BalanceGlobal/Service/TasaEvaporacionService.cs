
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

    public interface ITasaEvaporacionService
    {
        Task<ApiResponse> CreateTasaEvaporacion(TasaEvaporacionModel TasaEvaporacionModel, string userName);
        Task<ApiResponse> ReadTasaEvaporacion();
        Task<ApiResponse> UpdateTasaEvaporacion(TasaEvaporacionModel TasaEvaporacionModel, string userName);
        Task<ApiResponse> DeleteTasaEvaporacion(int id, string userName);
        Task<ApiResponse> ReadTasaEvaporacion(int id);
    }

    public class TasaEvaporacionService : ITasaEvaporacionService
    {
        private readonly ITasaEvaporacionRepository _repository;
        private readonly IMapper _mapper;

        public TasaEvaporacionService(ITasaEvaporacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTasaEvaporacion(TasaEvaporacionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TasaEvaporacion>(model);
                await _repository.AddAsync(result, userName);
                model.IdTasaEvaporacion = result.IdTasaEvaporacion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTasaEvaporacion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TasaEvaporacionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTasaEvaporacion(TasaEvaporacionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTasaEvaporacion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TasaEvaporacion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTasaEvaporacion(int id, string userName)
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

        public async Task<ApiResponse> ReadTasaEvaporacion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TasaEvaporacionModel>(model);

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

