
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

    public interface IQuimicaPlataformasService
    {
        Task<ApiResponse> CreateQuimicaPlataformas(QuimicaPlataformasModel QuimicaPlataformasModel, string userName);
        Task<ApiResponse> ReadQuimicaPlataformas();
        Task<ApiResponse> UpdateQuimicaPlataformas(QuimicaPlataformasModel QuimicaPlataformasModel, string userName);
        Task<ApiResponse> DeleteQuimicaPlataformas(int id, string userName);
        Task<ApiResponse> ReadQuimicaPlataformas(int id);
    }

    public class QuimicaPlataformasService : IQuimicaPlataformasService
    {
        private readonly IQuimicaPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public QuimicaPlataformasService(IQuimicaPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateQuimicaPlataformas(QuimicaPlataformasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<QuimicaPlataformas>(model);
                await _repository.AddAsync(result, userName);
                model.IdQuimicaPlataformas = result.IdQuimicaPlataformas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadQuimicaPlataformas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<QuimicaPlataformasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateQuimicaPlataformas(QuimicaPlataformasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdQuimicaPlataformas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<QuimicaPlataformas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteQuimicaPlataformas(int id, string userName)
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

        public async Task<ApiResponse> ReadQuimicaPlataformas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<QuimicaPlataformasModel>(model);

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

