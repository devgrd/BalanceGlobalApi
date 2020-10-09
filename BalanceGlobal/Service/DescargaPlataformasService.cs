
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

    public interface IDescargaPlataformasService
    {
        Task<ApiResponse> CreateDescargaPlataformas(DescargaPlataformasModel DescargaPlataformasModel, string userName);
        Task<ApiResponse> ReadDescargaPlataformas();
        Task<ApiResponse> UpdateDescargaPlataformas(DescargaPlataformasModel DescargaPlataformasModel, string userName);
        Task<ApiResponse> DeleteDescargaPlataformas(int id, string userName);
        Task<ApiResponse> ReadDescargaPlataformas(int id);
    }

    public class DescargaPlataformasService : IDescargaPlataformasService
    {
        private readonly IDescargaPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public DescargaPlataformasService(IDescargaPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateDescargaPlataformas(DescargaPlataformasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<DescargaPlataformas>(model);
                await _repository.AddAsync(result, userName);
                model.IdDescargaPlataformas = result.IdDescargaPlataformas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadDescargaPlataformas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<DescargaPlataformasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateDescargaPlataformas(DescargaPlataformasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdDescargaPlataformas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DescargaPlataformas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteDescargaPlataformas(int id, string userName)
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

        public async Task<ApiResponse> ReadDescargaPlataformas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DescargaPlataformasModel>(model);

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

