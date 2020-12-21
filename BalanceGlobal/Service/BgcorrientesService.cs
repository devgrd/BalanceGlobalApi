
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

    public interface IBgcorrientesService
    {
        Task<ApiResponse> CreateBgcorrientes(BgcorrientesModel BgcorrientesModel, string userName);
        Task<ApiResponse> ReadBgcorrientes();
        Task<ApiResponse> UpdateBgcorrientes(BgcorrientesModel BgcorrientesModel, string userName);
        Task<ApiResponse> DeleteBgcorrientes(int id, string userName);
        Task<ApiResponse> ReadBgcorrientes(int id);
    }

    public class BgcorrientesService : IBgcorrientesService
    {
        private readonly IBgcorrientesRepository _repository;
        private readonly IMapper _mapper;

        public BgcorrientesService(IBgcorrientesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateBgcorrientes(BgcorrientesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Bgcorrientes>(model);
                await _repository.AddAsync(result, userName);
                model.IdBgcorrientes = result.IdBgcorrientes;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadBgcorrientes()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<BgcorrientesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateBgcorrientes(BgcorrientesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdBgcorrientes);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Bgcorrientes>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteBgcorrientes(int id, string userName)
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

        public async Task<ApiResponse> ReadBgcorrientes(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<BgcorrientesModel>(model);

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
