
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

    public interface IOrigenesTraspasoPlataformasService
    {
        Task<ApiResponse> CreateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel OrigenesTraspasoPlataformasModel, string userName);
        Task<ApiResponse> ReadOrigenesTraspasoPlataformas();
        Task<ApiResponse> UpdateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel OrigenesTraspasoPlataformasModel, string userName);
        Task<ApiResponse> DeleteOrigenesTraspasoPlataformas(int id, string userName);
        Task<ApiResponse> ReadOrigenesTraspasoPlataformas(int id);
    }

    public class OrigenesTraspasoPlataformasService : IOrigenesTraspasoPlataformasService
    {
        private readonly IOrigenesTraspasoPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public OrigenesTraspasoPlataformasService(IOrigenesTraspasoPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<OrigenesTraspasoPlataformas>(model);
                await _repository.AddAsync(result, userName);
                model.IdOrigenesTraspasoPlataformas = result.IdOrigenesTraspasoPlataformas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadOrigenesTraspasoPlataformas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<OrigenesTraspasoPlataformasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdOrigenesTraspasoPlataformas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<OrigenesTraspasoPlataformas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteOrigenesTraspasoPlataformas(int id, string userName)
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

        public async Task<ApiResponse> ReadOrigenesTraspasoPlataformas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<OrigenesTraspasoPlataformasModel>(model);

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

