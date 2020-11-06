
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

    public interface IImpregnacionCosechasService
    {
        Task<ApiResponse> CreateImpregnacionCosechas(ImpregnacionCosechasModel ImpregnacionCosechasModel, string userName);
        Task<ApiResponse> ReadImpregnacionCosechasByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateImpregnacionCosechas(ImpregnacionCosechasModel ImpregnacionCosechasModel, string userName);
        Task<ApiResponse> DeleteImpregnacionCosechas(int id, string userName);
        Task<ApiResponse> ReadImpregnacionCosechas(int id);
    }

    public class ImpregnacionCosechasService : IImpregnacionCosechasService
    {
        private readonly IImpregnacionCosechasRepository _repository;
        private readonly IMapper _mapper;

        public ImpregnacionCosechasService(IImpregnacionCosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateImpregnacionCosechas(ImpregnacionCosechasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ImpregnacionCosechas>(model);
                await _repository.AddAsync(result, userName);
                model.IdImpregnacionCosechas = result.IdImpregnacionCosechas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadImpregnacionCosechasByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ImpregnacionCosechasModel>>(data);

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

        public async Task<ApiResponse> UpdateImpregnacionCosechas(ImpregnacionCosechasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdImpregnacionCosechas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImpregnacionCosechas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteImpregnacionCosechas(int id, string userName)
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

        public async Task<ApiResponse> ReadImpregnacionCosechas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImpregnacionCosechasModel>(model);

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

