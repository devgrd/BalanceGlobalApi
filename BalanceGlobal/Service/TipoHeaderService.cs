
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

    public interface ITipoHeaderService
    {
        Task<ApiResponse> CreateTipoHeader(TipoHeaderModel TipoHeaderModel, string userName);
        Task<ApiResponse> ReadTipoHeader();
        Task<ApiResponse> UpdateTipoHeader(TipoHeaderModel TipoHeaderModel, string userName);
        Task<ApiResponse> DeleteTipoHeader(int id, string userName);
        Task<ApiResponse> ReadTipoHeader(int id);
    }

    public class TipoHeaderService : ITipoHeaderService
    {
        private readonly ITipoHeaderRepository _repository;
        private readonly IMapper _mapper;

        public TipoHeaderService(ITipoHeaderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTipoHeader(TipoHeaderModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TipoHeader>(model);
                await _repository.AddAsync(result, userName);
                model.IdTipoHeader = result.IdTipoHeader;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTipoHeader()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TipoHeaderModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTipoHeader(TipoHeaderModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTipoHeader);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoHeader>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTipoHeader(int id, string userName)
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

        public async Task<ApiResponse> ReadTipoHeader(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoHeaderModel>(model);

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

