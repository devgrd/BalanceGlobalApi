
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

    public interface ICkmopIiquimaPorteoService
    {
        Task<ApiResponse> CreateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel CkmopIiquimaPorteoModel, string userName);
        Task<ApiResponse> ReadCkmopIiquimaPorteoByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel CkmopIiquimaPorteoModel, string userName);
        Task<ApiResponse> DeleteCkmopIiquimaPorteo(int id, string userName);
        Task<ApiResponse> ReadCkmopIiquimaPorteo(int id);
    }

    public class CkmopIiquimaPorteoService : ICkmopIiquimaPorteoService
    {
        private readonly ICkmopIiquimaPorteoRepository _repository;
        private readonly IMapper _mapper;

        public CkmopIiquimaPorteoService(ICkmopIiquimaPorteoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<CkmopIiquimaPorteo>(model);
                await _repository.AddAsync(result, userName);
                model.IdCkmopIiquimaPorteo = result.IdCkmopIiquimaPorteo;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCkmopIiquimaPorteoByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<CkmopIiquimaPorteoModel>>(data);

                if (result.Count == 0)
                {
                    return new ApiResponse("Not Found", 404);
                }

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCkmopIiquimaPorteo);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CkmopIiquimaPorteo>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCkmopIiquimaPorteo(int id, string userName)
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

        public async Task<ApiResponse> ReadCkmopIiquimaPorteo(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CkmopIiquimaPorteoModel>(model);

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

