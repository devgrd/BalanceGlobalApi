
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

    public interface IFaenasService
    {
        Task<ApiResponse> CreateFaenas(FaenasModel FaenasModel, string userName);
        Task<ApiResponse> ReadFaenas();
        Task<ApiResponse> UpdateFaenas(FaenasModel FaenasModel, string userName);
        Task<ApiResponse> DeleteFaenas(int id, string userName);
        Task<ApiResponse> ReadFaenas(int id);
    }

    public class FaenasService : IFaenasService
    {
        private readonly IFaenasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasService(IFaenasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateFaenas(FaenasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Faenas>(model);
                await _repository.AddAsync(result, userName);
                model.IdFaenas = result.IdFaenas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadFaenas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<FaenasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateFaenas(FaenasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdFaenas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Faenas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteFaenas(int id, string userName)
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

        public async Task<ApiResponse> ReadFaenas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<FaenasModel>(model);

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

