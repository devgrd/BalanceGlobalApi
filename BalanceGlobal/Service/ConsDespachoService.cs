
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

    public interface IConsDespachoService
    {
        Task<ApiResponse> CreateConsDespacho(ConsDespachoModel ConsDespachoModel, string userName);
        Task<ApiResponse> ReadConsDespachoByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateConsDespacho(ConsDespachoModel ConsDespachoModel, string userName);
        Task<ApiResponse> DeleteConsDespacho(int id, string userName);
        Task<ApiResponse> ReadConsDespacho(int id);
    }

    public class ConsDespachoService : IConsDespachoService
    {
        private readonly IConsDespachoRepository _repository;
        private readonly IMapper _mapper;

        public ConsDespachoService(IConsDespachoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsDespacho(ConsDespachoModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsDespacho>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsDespacho = result.IdConsDespacho;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsDespachoByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsDespachoModel>>(data);

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

        public async Task<ApiResponse> UpdateConsDespacho(ConsDespachoModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsDespacho);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsDespacho>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsDespacho(int id, string userName)
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

        public async Task<ApiResponse> ReadConsDespacho(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsDespachoModel>(model);

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

