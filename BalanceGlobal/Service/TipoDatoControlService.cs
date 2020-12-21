
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

    public interface ITipoDatoControlService
    {
        Task<ApiResponse> CreateTipoDatoControl(TipoDatoControlModel TipoDatoControlModel, string userName);
        Task<ApiResponse> ReadTipoDatoControl();
        Task<ApiResponse> UpdateTipoDatoControl(TipoDatoControlModel TipoDatoControlModel, string userName);
        Task<ApiResponse> DeleteTipoDatoControl(int id, string userName);
        Task<ApiResponse> ReadTipoDatoControl(int id);
    }

    public class TipoDatoControlService : ITipoDatoControlService
    {
        private readonly ITipoDatoControlRepository _repository;
        private readonly IMapper _mapper;

        public TipoDatoControlService(ITipoDatoControlRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTipoDatoControl(TipoDatoControlModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TipoDatoControl>(model);
                await _repository.AddAsync(result, userName);
                model.IdTipoDatoControl = result.IdTipoDatoControl;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTipoDatoControl()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TipoDatoControlModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTipoDatoControl(TipoDatoControlModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTipoDatoControl);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoDatoControl>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTipoDatoControl(int id, string userName)
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

        public async Task<ApiResponse> ReadTipoDatoControl(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TipoDatoControlModel>(model);

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
