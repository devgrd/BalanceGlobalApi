
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

    public interface ISistemasSubSistemasService
    {
        Task<ApiResponse> CreateSistemasSubSistemas(SistemasSubSistemasModel SistemasSubSistemasModel, string userName);
        Task<ApiResponse> ReadSistemasSubSistemas();
        Task<ApiResponse> UpdateSistemasSubSistemas(SistemasSubSistemasModel SistemasSubSistemasModel, string userName);
        Task<ApiResponse> DeleteSistemasSubSistemas(int id, string userName);
        Task<ApiResponse> ReadSistemasSubSistemas(int id);
    }

    public class SistemasSubSistemasService : ISistemasSubSistemasService
    {
        private readonly ISistemasSubSistemasRepository _repository;
        private readonly IMapper _mapper;

        public SistemasSubSistemasService(ISistemasSubSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSistemasSubSistemas(SistemasSubSistemasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<SistemasSubSistemas>(model);
                await _repository.AddAsync(result, userName);
                model.IdSistemasSubsistemas = result.IdSistemasSubsistemas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSistemasSubSistemas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<SistemasSubSistemasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSistemasSubSistemas(SistemasSubSistemasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSistemasSubsistemas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SistemasSubSistemas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSistemasSubSistemas(int id, string userName)
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

        public async Task<ApiResponse> ReadSistemasSubSistemas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SistemasSubSistemasModel>(model);

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

