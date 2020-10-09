
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

    public interface IReactivosService
    {
        Task<ApiResponse> CreateReactivos(ReactivosModel ReactivosModel, string userName);
        Task<ApiResponse> ReadReactivos();
        Task<ApiResponse> UpdateReactivos(ReactivosModel ReactivosModel, string userName);
        Task<ApiResponse> DeleteReactivos(int id, string userName);
        Task<ApiResponse> ReadReactivos(int id);
    }

    public class ReactivosService : IReactivosService
    {
        private readonly IReactivosRepository _repository;
        private readonly IMapper _mapper;

        public ReactivosService(IReactivosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateReactivos(ReactivosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Reactivos>(model);
                await _repository.AddAsync(result, userName);
                model.IdReactivos = result.IdReactivos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadReactivos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ReactivosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateReactivos(ReactivosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdReactivos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Reactivos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteReactivos(int id, string userName)
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

        public async Task<ApiResponse> ReadReactivos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ReactivosModel>(model);

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

