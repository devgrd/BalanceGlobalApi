
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

    public interface IConsumoEnergeticoService
    {
        Task<ApiResponse> CreateConsumoEnergetico(ConsumoEnergeticoModel ConsumoEnergeticoModel, string userName);
        Task<ApiResponse> ReadConsumoEnergeticoByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateConsumoEnergetico(ConsumoEnergeticoModel ConsumoEnergeticoModel, string userName);
        Task<ApiResponse> DeleteConsumoEnergetico(int id, string userName);
        Task<ApiResponse> ReadConsumoEnergetico(int id);
    }

    public class ConsumoEnergeticoService : IConsumoEnergeticoService
    {
        private readonly IConsumoEnergeticoRepository _repository;
        private readonly IMapper _mapper;

        public ConsumoEnergeticoService(IConsumoEnergeticoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsumoEnergetico(ConsumoEnergeticoModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsumoEnergetico>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsumoEnergetico = result.IdConsumoEnergetico;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsumoEnergeticoByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsumoEnergeticoModel>>(data);

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

        public async Task<ApiResponse> UpdateConsumoEnergetico(ConsumoEnergeticoModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsumoEnergetico);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsumoEnergetico>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsumoEnergetico(int id, string userName)
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

        public async Task<ApiResponse> ReadConsumoEnergetico(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsumoEnergeticoModel>(model);

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

