
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

    public interface IConsumoAguaService
    {
        Task<ApiResponse> CreateConsumoAgua(ConsumoAguaModel ConsumoAguaModel, string userName);
        Task<ApiResponse> UpdateConsumoAgua(ConsumoAguaModel ConsumoAguaModel, string userName);
        Task<ApiResponse> DeleteConsumoAgua(int id, string userName);
        Task<ApiResponse> ReadConsumoAgua(int id);
        Task<ApiResponse> ReadConsumoAguaByPeriodos(int IdPeriodo);
    }

    public class ConsumoAguaService : IConsumoAguaService
    {
        private readonly IConsumoAguaRepository _repository;
        private readonly IMapper _mapper;

        public ConsumoAguaService(IConsumoAguaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> ReadConsumoAguaByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsumoAguaModel>>(data);

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

        public async Task<ApiResponse> CreateConsumoAgua(ConsumoAguaModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsumoAgua>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsumoAgua = result.IdConsumoAgua;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateConsumoAgua(ConsumoAguaModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsumoAgua);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsumoAgua>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsumoAgua(int id, string userName)
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

        public async Task<ApiResponse> ReadConsumoAgua(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsumoAguaModel>(model);

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

