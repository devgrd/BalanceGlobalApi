
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

    public interface IImportacionesUserParValuesService
    {
        Task<ApiResponse> CreateImportacionesUserParValues(ImportacionesUserParValuesModel ImportacionesUserParValuesModel, string userName);
        Task<ApiResponse> ReadImportacionesUserParValues();
        Task<ApiResponse> UpdateImportacionesUserParValues(ImportacionesUserParValuesModel ImportacionesUserParValuesModel, string userName);
        Task<ApiResponse> DeleteImportacionesUserParValues(int id, string userName);
        Task<ApiResponse> ReadImportacionesUserParValues(int id);
    }

    public class ImportacionesUserParValuesService : IImportacionesUserParValuesService
    {
        private readonly IImportacionesUserParValuesRepository _repository;
        private readonly IMapper _mapper;

        public ImportacionesUserParValuesService(IImportacionesUserParValuesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateImportacionesUserParValues(ImportacionesUserParValuesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ImportacionesUserParValues>(model);
                await _repository.AddAsync(result, userName);
                model.IdImportacionesUserParValues = result.IdImportacionesUserParValues;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadImportacionesUserParValues()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ImportacionesUserParValuesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateImportacionesUserParValues(ImportacionesUserParValuesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdImportacionesUserParValues);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportacionesUserParValues>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteImportacionesUserParValues(int id, string userName)
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

        public async Task<ApiResponse> ReadImportacionesUserParValues(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportacionesUserParValuesModel>(model);

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

