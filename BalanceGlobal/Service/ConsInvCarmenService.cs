
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

    public interface IConsInvCarmenService
    {
        Task<ApiResponse> CreateConsInvCarmen(ConsInvCarmenModel ConsInvCarmenModel, string userName);
        Task<ApiResponse> ReadConsInvCarmenByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateConsInvCarmen(ConsInvCarmenModel ConsInvCarmenModel, string userName);
        Task<ApiResponse> DeleteConsInvCarmen(int id, string userName);
        Task<ApiResponse> ReadConsInvCarmen(int id);
    }

    public class ConsInvCarmenService : IConsInvCarmenService
    {
        private readonly IConsInvCarmenRepository _repository;
        private readonly IMapper _mapper;

        public ConsInvCarmenService(IConsInvCarmenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsInvCarmen(ConsInvCarmenModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsInvCarmen>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsInvCarmen = result.IdConsInvCarmen;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsInvCarmenByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsInvCarmenModel>>(data);

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

        public async Task<ApiResponse> UpdateConsInvCarmen(ConsInvCarmenModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsInvCarmen);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsInvCarmen>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsInvCarmen(int id, string userName)
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

        public async Task<ApiResponse> ReadConsInvCarmen(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsInvCarmenModel>(model);

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

