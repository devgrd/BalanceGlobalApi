
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

    public interface IReinyeccionService
    {
        Task<ApiResponse> CreateReinyeccion(ReinyeccionModel ReinyeccionModel, string userName);
        Task<ApiResponse> ReadReinyeccion();
        Task<ApiResponse> UpdateReinyeccion(ReinyeccionModel ReinyeccionModel, string userName);
        Task<ApiResponse> DeleteReinyeccion(int id, string userName);
        Task<ApiResponse> ReadReinyeccion(int id);
    }

    public class ReinyeccionService : IReinyeccionService
    {
        private readonly IReinyeccionRepository _repository;
        private readonly IMapper _mapper;

        public ReinyeccionService(IReinyeccionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateReinyeccion(ReinyeccionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Reinyeccion>(model);
                await _repository.AddAsync(result, userName);
                model.IdReinyeccion = result.IdReinyeccion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadReinyeccion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ReinyeccionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateReinyeccion(ReinyeccionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdReinyeccion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Reinyeccion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteReinyeccion(int id, string userName)
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

        public async Task<ApiResponse> ReadReinyeccion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ReinyeccionModel>(model);

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

