
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

    public interface IPciacopiosOrigenService
    {
        Task<ApiResponse> CreatePciacopiosOrigen(PciacopiosOrigenModel PciacopiosOrigenModel, string userName);
        Task<ApiResponse> ReadPciacopiosOrigen();
        Task<ApiResponse> UpdatePciacopiosOrigen(PciacopiosOrigenModel PciacopiosOrigenModel, string userName);
        Task<ApiResponse> DeletePciacopiosOrigen(int id, string userName);
        Task<ApiResponse> ReadPciacopiosOrigen(int id);
    }

    public class PciacopiosOrigenService : IPciacopiosOrigenService
    {
        private readonly IPciacopiosOrigenRepository _repository;
        private readonly IMapper _mapper;

        public PciacopiosOrigenService(IPciacopiosOrigenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePciacopiosOrigen(PciacopiosOrigenModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<PciacopiosOrigen>(model);
                await _repository.AddAsync(result, userName);
                model.IdPciacopiosOrigen = result.IdPciacopiosOrigen;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPciacopiosOrigen()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PciacopiosOrigenModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdatePciacopiosOrigen(PciacopiosOrigenModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPciacopiosOrigen);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PciacopiosOrigen>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePciacopiosOrigen(int id, string userName)
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

        public async Task<ApiResponse> ReadPciacopiosOrigen(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PciacopiosOrigenModel>(model);

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

