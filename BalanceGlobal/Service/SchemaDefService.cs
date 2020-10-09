
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

    public interface ISchemaDefService
    {
        Task<ApiResponse> CreateSchemaDef(SchemaDefModel SchemaDefModel, string userName);
        Task<ApiResponse> ReadSchemaDef();
        Task<ApiResponse> UpdateSchemaDef(SchemaDefModel SchemaDefModel, string userName);
        Task<ApiResponse> DeleteSchemaDef(int id, string userName);
        Task<ApiResponse> ReadSchemaDef(int id);
    }

    public class SchemaDefService : ISchemaDefService
    {
        private readonly ISchemaDefRepository _repository;
        private readonly IMapper _mapper;

        public SchemaDefService(ISchemaDefRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSchemaDef(SchemaDefModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<SchemaDef>(model);
                await _repository.AddAsync(result, userName);
                model.IdSchemaDef = result.IdSchemaDef;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSchemaDef()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<SchemaDefModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSchemaDef(SchemaDefModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSchemaDef);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SchemaDef>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSchemaDef(int id, string userName)
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

        public async Task<ApiResponse> ReadSchemaDef(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SchemaDefModel>(model);

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

