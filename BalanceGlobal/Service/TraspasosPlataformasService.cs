
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

    public interface ITraspasosPlataformasService
    {
        Task<ApiResponse> CreateTraspasosPlataformas(TraspasosPlataformasModel TraspasosPlataformasModel, string userName);
        Task<ApiResponse> ReadTraspasosPlataformasByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateTraspasosPlataformas(TraspasosPlataformasModel TraspasosPlataformasModel, string userName);
        Task<ApiResponse> DeleteTraspasosPlataformas(int id, string userName);
        Task<ApiResponse> ReadTraspasosPlataformas(int id);
    }

    public class TraspasosPlataformasService : ITraspasosPlataformasService
    {
        private readonly ITraspasosPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public TraspasosPlataformasService(ITraspasosPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTraspasosPlataformas(TraspasosPlataformasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TraspasosPlataformas>(model);
                await _repository.AddAsync(result, userName);
                model.IdTraspasosPlataformas = result.IdTraspasosPlataformas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTraspasosPlataformasByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<TraspasosPlataformasModel>>(data);

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

        public async Task<ApiResponse> UpdateTraspasosPlataformas(TraspasosPlataformasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTraspasosPlataformas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TraspasosPlataformas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTraspasosPlataformas(int id, string userName)
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

        public async Task<ApiResponse> ReadTraspasosPlataformas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TraspasosPlataformasModel>(model);

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

