
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

    public interface IExtraccionAguaService
    {
        Task<ApiResponse> CreateExtraccionAgua(ExtraccionAguaModel ExtraccionAguaModel, string userName);
        Task<ApiResponse> ReadExtraccionAguaByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateExtraccionAgua(ExtraccionAguaModel ExtraccionAguaModel, string userName);
        Task<ApiResponse> DeleteExtraccionAgua(int id, string userName);
        Task<ApiResponse> ReadExtraccionAgua(int id);
    }

    public class ExtraccionAguaService : IExtraccionAguaService
    {
        private readonly IExtraccionAguaRepository _repository;
        private readonly IMapper _mapper;

        public ExtraccionAguaService(IExtraccionAguaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateExtraccionAgua(ExtraccionAguaModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ExtraccionAgua>(model);
                await _repository.AddAsync(result, userName);
                model.IdExtraccionAgua = result.IdExtraccionAgua;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadExtraccionAguaByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ExtraccionAguaModel>>(data);

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

        public async Task<ApiResponse> UpdateExtraccionAgua(ExtraccionAguaModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdExtraccionAgua);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ExtraccionAgua>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteExtraccionAgua(int id, string userName)
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

        public async Task<ApiResponse> ReadExtraccionAgua(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ExtraccionAguaModel>(model);

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

