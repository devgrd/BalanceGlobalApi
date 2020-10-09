
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

    public interface IImportadoresUserParService
    {
        Task<ApiResponse> CreateImportadoresUserPar(ImportadoresUserParModel ImportadoresUserParModel, string userName);
        Task<ApiResponse> ReadImportadoresUserPar();
        Task<ApiResponse> UpdateImportadoresUserPar(ImportadoresUserParModel ImportadoresUserParModel, string userName);
        Task<ApiResponse> DeleteImportadoresUserPar(int id, string userName);
        Task<ApiResponse> ReadImportadoresUserPar(int id);
    }

    public class ImportadoresUserParService : IImportadoresUserParService
    {
        private readonly IImportadoresUserParRepository _repository;
        private readonly IMapper _mapper;

        public ImportadoresUserParService(IImportadoresUserParRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateImportadoresUserPar(ImportadoresUserParModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ImportadoresUserPar>(model);
                await _repository.AddAsync(result, userName);
                model.IdImportadoresUserPar = result.IdImportadoresUserPar;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadImportadoresUserPar()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ImportadoresUserParModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateImportadoresUserPar(ImportadoresUserParModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdImportadoresUserPar);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportadoresUserPar>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteImportadoresUserPar(int id, string userName)
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

        public async Task<ApiResponse> ReadImportadoresUserPar(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportadoresUserParModel>(model);

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

