
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

    public interface ISchemaColumnsService
    {
        Task<ApiResponse> CreateSchemaColumns(SchemaColumnsModel SchemaColumnsModel, string userName);
        Task<ApiResponse> ReadSchemaColumns(string nombre);
        Task<ApiResponse> UpdateSchemaColumns(SchemaColumnsModel SchemaColumnsModel, string userName);
        Task<ApiResponse> DeleteSchemaColumns(int id, string userName);
        Task<ApiResponse> ReadSchemaColumns(int idSchemaDef);
    }

    public class SchemaColumnsService : ISchemaColumnsService
    {
        private readonly ISchemaColumnsRepository _repository;
        private readonly IMapper _mapper;

        public SchemaColumnsService(ISchemaColumnsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSchemaColumns(SchemaColumnsModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<SchemaColumns>(model);
                await _repository.AddAsync(result, userName);
                model.IdSchemaColumns = result.IdSchemaColumns;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSchemaColumns(string nombre)
        {
            try
            {
                var data = await _repository.GetSchemaColumns(nombre);
                var result = _mapper.Map<List<SchemaColumnsModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSchemaColumns(SchemaColumnsModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSchemaColumns);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SchemaColumns>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSchemaColumns(int id, string userName)
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

        public async Task<ApiResponse> ReadSchemaColumns(int id)
        {
            try
            {
                var model = await _repository.GetManyAsync(x => x.IdSchemaDef == id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<List<SchemaColumnsModel>>(model);

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

