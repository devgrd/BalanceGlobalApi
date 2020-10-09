
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

    public interface IExtraccionService
    {
        Task<ApiResponse> CreateExtraccion(ExtraccionModel ExtraccionModel, string userName);
        Task<ApiResponse> ReadExtraccion();
        Task<ApiResponse> UpdateExtraccion(ExtraccionModel ExtraccionModel, string userName);
        Task<ApiResponse> DeleteExtraccion(int id, string userName);
        Task<ApiResponse> ReadExtraccion(int id);
    }

    public class ExtraccionService : IExtraccionService
    {
        private readonly IExtraccionRepository _repository;
        private readonly IMapper _mapper;

        public ExtraccionService(IExtraccionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateExtraccion(ExtraccionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Extraccion>(model);
                await _repository.AddAsync(result, userName);
                model.IdExtraccion = result.IdExtraccion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadExtraccion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ExtraccionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateExtraccion(ExtraccionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdExtraccion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Extraccion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteExtraccion(int id, string userName)
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

        public async Task<ApiResponse> ReadExtraccion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ExtraccionModel>(model);

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

