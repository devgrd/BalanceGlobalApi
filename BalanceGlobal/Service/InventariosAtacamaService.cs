
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

    public interface IInventariosAtacamaService
    {
        Task<ApiResponse> CreateInventariosAtacama(InventariosAtacamaModel InventariosAtacamaModel, string userName);
        Task<ApiResponse> UpdateInventariosAtacama(InventariosAtacamaModel InventariosAtacamaModel, string userName);
        Task<ApiResponse> DeleteInventariosAtacama(int id, string userName);
        Task<ApiResponse> ReadInventariosAtacama(int id);
        Task<ApiResponse> ReadInventariosAtacamaByPeriodos(int IdPeriodos);
    }

    public class InventariosAtacamaService : IInventariosAtacamaService
    {
        private readonly IInventariosAtacamaRepository _repository;
        private readonly IMapper _mapper;

        public InventariosAtacamaService(IInventariosAtacamaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> ReadInventariosAtacamaByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodo == IdPeriodo);
                var result = _mapper.Map<List<InventariosAtacamaModel>>(data);

                if (result.Count == 0)
                {
                    return new ApiResponse("Not Found", 404);
                }

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> CreateInventariosAtacama(InventariosAtacamaModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<InventariosAtacama>(model);
                await _repository.AddAsync(result, userName);
                model.IdInventariosAtacama = result.IdInventariosAtacama;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateInventariosAtacama(InventariosAtacamaModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdInventariosAtacama);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<InventariosAtacama>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteInventariosAtacama(int id, string userName)
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

        public async Task<ApiResponse> ReadInventariosAtacama(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<InventariosAtacamaModel>(model);

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

