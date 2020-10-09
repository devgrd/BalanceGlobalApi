
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

    public interface IImportDestinoService
    {
        Task<ApiResponse> CreateImportDestino(ImportDestinoModel ImportDestinoModel, string userName);
        Task<ApiResponse> ReadImportDestino();
        Task<ApiResponse> UpdateImportDestino(ImportDestinoModel ImportDestinoModel, string userName);
        Task<ApiResponse> DeleteImportDestino(int id, string userName);
        Task<ApiResponse> ReadImportDestino(int id);
    }

    public class ImportDestinoService : IImportDestinoService
    {
        private readonly IImportDestinoRepository _repository;
        private readonly IMapper _mapper;

        public ImportDestinoService(IImportDestinoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateImportDestino(ImportDestinoModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ImportDestino>(model);
                await _repository.AddAsync(result, userName);
                model.IdImportDestino = result.IdImportDestino;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadImportDestino()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ImportDestinoModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateImportDestino(ImportDestinoModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdImportDestino);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportDestino>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteImportDestino(int id, string userName)
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

        public async Task<ApiResponse> ReadImportDestino(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportDestinoModel>(model);

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

