
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

    public interface ICkmopIivolaPorteoService
    {
        Task<ApiResponse> CreateCkmopIivolaPorteo(CkmopIivolaPorteoModel CkmopIivolaPorteoModel, string userName);
        Task<ApiResponse> ReadCkmopIivolaPorteo();
        Task<ApiResponse> UpdateCkmopIivolaPorteo(CkmopIivolaPorteoModel CkmopIivolaPorteoModel, string userName);
        Task<ApiResponse> DeleteCkmopIivolaPorteo(int id, string userName);
        Task<ApiResponse> ReadCkmopIivolaPorteo(int id);
    }

    public class CkmopIivolaPorteoService : ICkmopIivolaPorteoService
    {
        private readonly ICkmopIivolaPorteoRepository _repository;
        private readonly IMapper _mapper;

        public CkmopIivolaPorteoService(ICkmopIivolaPorteoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCkmopIivolaPorteo(CkmopIivolaPorteoModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<CkmopIivolaPorteo>(model);
                await _repository.AddAsync(result, userName);
                model.IdCkmopIivolaPorteo = result.IdCkmopIivolaPorteo;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCkmopIivolaPorteo()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CkmopIivolaPorteoModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCkmopIivolaPorteo(CkmopIivolaPorteoModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCkmopIivolaPorteo);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CkmopIivolaPorteo>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCkmopIivolaPorteo(int id, string userName)
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

        public async Task<ApiResponse> ReadCkmopIivolaPorteo(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CkmopIivolaPorteoModel>(model);

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

