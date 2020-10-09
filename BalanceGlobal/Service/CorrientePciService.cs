
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

    public interface ICorrientePciService
    {
        Task<ApiResponse> CreateCorrientePci(CorrientePciModel CorrientePciModel, string userName);
        Task<ApiResponse> ReadCorrientePci();
        Task<ApiResponse> UpdateCorrientePci(CorrientePciModel CorrientePciModel, string userName);
        Task<ApiResponse> DeleteCorrientePci(int id, string userName);
        Task<ApiResponse> ReadCorrientePci(int id);
    }

    public class CorrientePciService : ICorrientePciService
    {
        private readonly ICorrientePciRepository _repository;
        private readonly IMapper _mapper;

        public CorrientePciService(ICorrientePciRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateCorrientePci(CorrientePciModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<CorrientePci>(model);
                await _repository.AddAsync(result, userName);
                model.IdCorrientePci = result.IdCorrientePci;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadCorrientePci()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<CorrientePciModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateCorrientePci(CorrientePciModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdCorrientePci);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrientePci>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteCorrientePci(int id, string userName)
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

        public async Task<ApiResponse> ReadCorrientePci(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<CorrientePciModel>(model);

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

