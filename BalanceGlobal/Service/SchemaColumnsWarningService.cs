
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

    public interface ISchemaColumnsWarningService
    {
        Task<ApiResponse> CreateSchemaColumnsWarning(SchemaColumnsWarningModel SchemaColumnsWarningModel, string userName);
        Task<ApiResponse> ReadSchemaColumnsWarning(string nombre);
        Task<ApiResponse> UpdateSchemaColumnsWarning(SchemaColumnsWarningModel SchemaColumnsWarningModel, string userName);
        Task<ApiResponse> DeleteSchemaColumnsWarning(int id, string userName);
        Task<ApiResponse> ReadSchemaColumnsWarning(int id);
    }

    public class SchemaColumnsWarningService : ISchemaColumnsWarningService
    {
        private readonly ISchemaColumnsWarningRepository _repository;
        private readonly IMapper _mapper;

        public SchemaColumnsWarningService(ISchemaColumnsWarningRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSchemaColumnsWarning(SchemaColumnsWarningModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<SchemaColumnsWarning>(model);
                await _repository.AddAsync(result, userName);
                model.IdSchemaColumnsWarning = result.IdSchemaColumnsWarning;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSchemaColumnsWarning(string nombre)
        {
            try
            {
                var data = await _repository.GetSchemaColumnsWarning(nombre);
                var result = _mapper.Map<List<SchemaColumnsWarningModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSchemaColumnsWarning(SchemaColumnsWarningModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSchemaColumnsWarning);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SchemaColumnsWarning>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSchemaColumnsWarning(int id, string userName)
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

        public async Task<ApiResponse> ReadSchemaColumnsWarning(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SchemaColumnsWarningModel>(model);

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

