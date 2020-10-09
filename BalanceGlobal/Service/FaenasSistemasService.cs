
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

    public interface IFaenasSistemasService
    {
        Task<ApiResponse> CreateFaenasSistemas(FaenasSistemasModel FaenasSistemasModel, string userName);
        Task<ApiResponse> ReadFaenasSistemas();
        Task<ApiResponse> UpdateFaenasSistemas(FaenasSistemasModel FaenasSistemasModel, string userName);
        Task<ApiResponse> DeleteFaenasSistemas(int id, string userName);
        Task<ApiResponse> ReadFaenasSistemas(int id);
    }

    public class FaenasSistemasService : IFaenasSistemasService
    {
        private readonly IFaenasSistemasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasSistemasService(IFaenasSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateFaenasSistemas(FaenasSistemasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<FaenasSistemas>(model);
                await _repository.AddAsync(result, userName);
                model.IdFaenasSistemas = result.IdFaenasSistemas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadFaenasSistemas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<FaenasSistemasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateFaenasSistemas(FaenasSistemasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdFaenasSistemas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<FaenasSistemas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteFaenasSistemas(int id, string userName)
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

        public async Task<ApiResponse> ReadFaenasSistemas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<FaenasSistemasModel>(model);

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

