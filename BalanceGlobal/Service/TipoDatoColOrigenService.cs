
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

    public interface ITipoDatoColOrigenService
    {
        Task<ApiResponse> CreateTipoDatoColOrigen(TipoDatoColOrigenModel TipoDatoColOrigenModel, string userName);
        Task<ApiResponse> ReadTipoDatoColOrigen();
        Task<ApiResponse> UpdateTipoDatoColOrigen(TipoDatoColOrigenModel TipoDatoColOrigenModel, string userName);
        Task<ApiResponse> DeleteTipoDatoColOrigen(int id, string userName);
        Task<ApiResponse> ReadTipoDatoColOrigen(int id);
    }

    public class TipoDatoColOrigenService : ITipoDatoColOrigenService
    {
        private readonly ITipoDatoColOrigenRepository _repository;
        private readonly IMapper _mapper;

        public TipoDatoColOrigenService(ITipoDatoColOrigenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTipoDatoColOrigen(TipoDatoColOrigenModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TipoDatoColOrigen>(model);
                await _repository.AddAsync(result, userName);
                model.IdTipoDatoColOrigen = result.IdTipoDatoColOrigen;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTipoDatoColOrigen()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TipoDatoColOrigenModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTipoDatoColOrigen(TipoDatoColOrigenModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTipoDatoColOrigen);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoDatoColOrigen>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTipoDatoColOrigen(int id, string userName)
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

        public async Task<ApiResponse> ReadTipoDatoColOrigen(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoDatoColOrigenModel>(model);

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

