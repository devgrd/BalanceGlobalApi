
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

    public interface ITipoSalService
    {
        Task<ApiResponse> CreateTipoSal(TipoSalModel TipoSalModel, string userName);
        Task<ApiResponse> ReadTipoSal();
        Task<ApiResponse> UpdateTipoSal(TipoSalModel TipoSalModel, string userName);
        Task<ApiResponse> DeleteTipoSal(int id, string userName);
        Task<ApiResponse> ReadTipoSal(int id);
    }

    public class TipoSalService : ITipoSalService
    {
        private readonly ITipoSalRepository _repository;
        private readonly IMapper _mapper;

        public TipoSalService(ITipoSalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTipoSal(TipoSalModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TipoSal>(model);
                await _repository.AddAsync(result, userName);
                model.IdTipoSal = result.IdTipoSal;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTipoSal()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TipoSalModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTipoSal(TipoSalModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTipoSal);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoSal>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTipoSal(int id, string userName)
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

        public async Task<ApiResponse> ReadTipoSal(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoSalModel>(model);

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

