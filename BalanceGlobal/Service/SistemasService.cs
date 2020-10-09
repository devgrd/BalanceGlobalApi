
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

    public interface ISistemasService
    {
        Task<ApiResponse> CreateSistemas(SistemasModel SistemasModel, string userName);
        Task<ApiResponse> ReadSistemas();
        Task<ApiResponse> UpdateSistemas(SistemasModel SistemasModel, string userName);
        Task<ApiResponse> DeleteSistemas(int id, string userName);
        Task<ApiResponse> ReadSistemas(int id);
    }

    public class SistemasService : ISistemasService
    {
        private readonly ISistemasRepository _repository;
        private readonly IMapper _mapper;

        public SistemasService(ISistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSistemas(SistemasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Sistemas>(model);
                await _repository.AddAsync(result, userName);
                model.IdSistemas = result.IdSistemas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSistemas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<SistemasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSistemas(SistemasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSistemas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Sistemas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSistemas(int id, string userName)
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

        public async Task<ApiResponse> ReadSistemas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SistemasModel>(model);

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

