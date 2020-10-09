
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

    public interface IReservoriosService
    {
        Task<ApiResponse> CreateReservorios(ReservoriosModel ReservoriosModel, string userName);
        Task<ApiResponse> ReadReservorios();
        Task<ApiResponse> UpdateReservorios(ReservoriosModel ReservoriosModel, string userName);
        Task<ApiResponse> DeleteReservorios(int id, string userName);
        Task<ApiResponse> ReadReservorios(int id);
    }

    public class ReservoriosService : IReservoriosService
    {
        private readonly IReservoriosRepository _repository;
        private readonly IMapper _mapper;

        public ReservoriosService(IReservoriosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateReservorios(ReservoriosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Reservorios>(model);
                await _repository.AddAsync(result, userName);
                model.IdReservorios = result.IdReservorios;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadReservorios()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ReservoriosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateReservorios(ReservoriosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdReservorios);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Reservorios>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteReservorios(int id, string userName)
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

        public async Task<ApiResponse> ReadReservorios(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ReservoriosModel>(model);

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

