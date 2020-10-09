
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

    public interface IImportacionesService
    {
        Task<ApiResponse> CreateImportaciones(ImportacionesModel ImportacionesModel, string userName);
        Task<ApiResponse> ReadImportaciones();
        Task<ApiResponse> UpdateImportaciones(ImportacionesModel ImportacionesModel, string userName);
        Task<ApiResponse> DeleteImportaciones(int id, string userName);
        Task<ApiResponse> ReadImportaciones(int id);
    }

    public class ImportacionesService : IImportacionesService
    {
        private readonly IImportacionesRepository _repository;
        private readonly IMapper _mapper;

        public ImportacionesService(IImportacionesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateImportaciones(ImportacionesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Importaciones>(model);
                await _repository.AddAsync(result, userName);
                model.IdImportaciones = result.IdImportaciones;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadImportaciones()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ImportacionesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateImportaciones(ImportacionesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdImportaciones);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Importaciones>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteImportaciones(int id, string userName)
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

        public async Task<ApiResponse> ReadImportaciones(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImportacionesModel>(model);

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

