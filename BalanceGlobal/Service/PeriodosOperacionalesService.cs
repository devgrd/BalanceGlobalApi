
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

    public interface IPeriodosOperacionalesService
    {
        Task<ApiResponse> CreatePeriodosOperacionales(PeriodosOperacionalesModel PeriodosOperacionalesModel, string userName);
        Task<ApiResponse> ReadPeriodosOperacionales();
        Task<ApiResponse> UpdatePeriodosOperacionales(PeriodosOperacionalesModel PeriodosOperacionalesModel, string userName);
        Task<ApiResponse> DeletePeriodosOperacionales(int id, string userName);
        Task<ApiResponse> ReadPeriodosOperacionales(int id);
    }

    public class PeriodosOperacionalesService : IPeriodosOperacionalesService
    {
        private readonly IPeriodosOperacionalesRepository _repository;
        private readonly IMapper _mapper;

        public PeriodosOperacionalesService(IPeriodosOperacionalesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePeriodosOperacionales(PeriodosOperacionalesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<PeriodosOperacionales>(model);
                await _repository.AddAsync(result, userName);
                model.IdPeriodosOperacionales = result.IdPeriodosOperacionales;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPeriodosOperacionales()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PeriodosOperacionalesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdatePeriodosOperacionales(PeriodosOperacionalesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPeriodosOperacionales);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PeriodosOperacionales>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePeriodosOperacionales(int id, string userName)
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

        public async Task<ApiResponse> ReadPeriodosOperacionales(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PeriodosOperacionalesModel>(model);

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

