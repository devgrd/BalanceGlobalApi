
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

    public interface IAliasesService
    {
        Task<ApiResponse> CreateAliases(AliasesModel AliasesModel, string userName);
        Task<ApiResponse> ReadAliases();
        Task<ApiResponse> UpdateAliases(AliasesModel AliasesModel, string userName);
        Task<ApiResponse> DeleteAliases(int id, string userName);
        Task<ApiResponse> ReadAliases(int id);
    }

    public class AliasesService : IAliasesService
    {
        private readonly IAliasesRepository _repository;
        private readonly IMapper _mapper;

        public AliasesService(IAliasesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateAliases(AliasesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Aliases>(model);
                await _repository.AddAsync(result, userName);
                model.IdAliases = result.IdAliases;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadAliases()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<AliasesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateAliases(AliasesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdAliases);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Aliases>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteAliases(int id, string userName)
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

        public async Task<ApiResponse> ReadAliases(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<AliasesModel>(model);

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

