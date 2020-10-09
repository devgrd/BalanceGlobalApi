
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

    public interface ISubSistemasService
    {
        Task<ApiResponse> CreateSubSistemas(SubSistemasModel SubSistemasModel, string userName);
        Task<ApiResponse> ReadSubSistemas();
        Task<ApiResponse> UpdateSubSistemas(SubSistemasModel SubSistemasModel, string userName);
        Task<ApiResponse> DeleteSubSistemas(int id, string userName);
        Task<ApiResponse> ReadSubSistemas(int id);
    }

    public class SubSistemasService : ISubSistemasService
    {
        private readonly ISubSistemasRepository _repository;
        private readonly IMapper _mapper;

        public SubSistemasService(ISubSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateSubSistemas(SubSistemasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<SubSistemas>(model);
                await _repository.AddAsync(result, userName);
                model.IdSubSistemas = result.IdSubSistemas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadSubSistemas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<SubSistemasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateSubSistemas(SubSistemasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdSubSistemas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SubSistemas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteSubSistemas(int id, string userName)
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

        public async Task<ApiResponse> ReadSubSistemas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<SubSistemasModel>(model);

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

