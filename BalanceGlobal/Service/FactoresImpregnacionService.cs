
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

    public interface IFactoresImpregnacionService
    {
        Task<ApiResponse> CreateFactoresImpregnacion(FactoresImpregnacionModel FactoresImpregnacionModel, string userName);
        Task<ApiResponse> ReadFactoresImpregnacion();
        Task<ApiResponse> UpdateFactoresImpregnacion(FactoresImpregnacionModel FactoresImpregnacionModel, string userName);
        Task<ApiResponse> DeleteFactoresImpregnacion(int id, string userName);
        Task<ApiResponse> ReadFactoresImpregnacion(int id);
    }

    public class FactoresImpregnacionService : IFactoresImpregnacionService
    {
        private readonly IFactoresImpregnacionRepository _repository;
        private readonly IMapper _mapper;

        public FactoresImpregnacionService(IFactoresImpregnacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateFactoresImpregnacion(FactoresImpregnacionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<FactoresImpregnacion>(model);
                await _repository.AddAsync(result, userName);
                model.IdFactoresImpregnacion = result.IdFactoresImpregnacion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadFactoresImpregnacion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<FactoresImpregnacionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateFactoresImpregnacion(FactoresImpregnacionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdFactoresImpregnacion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<FactoresImpregnacion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteFactoresImpregnacion(int id, string userName)
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

        public async Task<ApiResponse> ReadFactoresImpregnacion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<FactoresImpregnacionModel>(model);

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

