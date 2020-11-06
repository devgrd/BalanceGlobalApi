
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

    public interface ICargaPlataformasService
    {
        Task<ApiResponse> CreateCargaPlataformas(CargaPlataformasModel CargaPlataformasModel, string userName);
        Task<ApiResponse> ReadCargaPlataformasByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateCargaPlataformas(CargaPlataformasModel CargaPlataformasModel, string userName);
        Task<ApiResponse> DeleteCargaPlataformas(int id, string userName);
        Task<ApiResponse> ReadCargaPlataformas(int id);
    }

    public class CargaPlataformasService : ICargaPlataformasService
    {
        private readonly ICargaPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public CargaPlataformasService(ICargaPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCargaPlataformas(CargaPlataformasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<CargaPlataformas>(model);
                await _repository.AddAsync(result, userName);
                model.IdCargaPlataformas = result.IdCargaPlataformas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCargaPlataformasByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<CargaPlataformasModel>>(data);

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

        public async Task<ApiResponse> UpdateCargaPlataformas(CargaPlataformasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCargaPlataformas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CargaPlataformas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCargaPlataformas(int id, string userName)
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

        public async Task<ApiResponse> ReadCargaPlataformas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CargaPlataformasModel>(model);

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

