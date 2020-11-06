
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

    public interface IPciacopiosCliService
    {
        Task<ApiResponse> CreatePciacopiosCli(PciacopiosCliModel PciacopiosCliModel, string userName);
        Task<ApiResponse> ReadPciacopiosCliByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdatePciacopiosCli(PciacopiosCliModel PciacopiosCliModel, string userName);
        Task<ApiResponse> DeletePciacopiosCli(int id, string userName);
        Task<ApiResponse> ReadPciacopiosCli(int id);
    }

    public class PciacopiosCliService : IPciacopiosCliService
    {
        private readonly IPciacopiosCliRepository _repository;
        private readonly IMapper _mapper;

        public PciacopiosCliService(IPciacopiosCliRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePciacopiosCli(PciacopiosCliModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<PciacopiosCli>(model);
                await _repository.AddAsync(result, userName);
                model.IdPciacopiosCli = result.IdPciacopiosCli;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPciacopiosCliByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<PciacopiosCliModel>>(data);

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

        public async Task<ApiResponse> UpdatePciacopiosCli(PciacopiosCliModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPciacopiosCli);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PciacopiosCli>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePciacopiosCli(int id, string userName)
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

        public async Task<ApiResponse> ReadPciacopiosCli(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PciacopiosCliModel>(model);

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

