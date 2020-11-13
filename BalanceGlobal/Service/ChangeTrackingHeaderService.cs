
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

    public interface IChangeTrackingHeaderService
    {
        Task<ApiResponse> CreateChangeTrackingHeader(ChangeTrackingHeaderModel ChangeTrackingHeaderModel, string userName);
        Task<ApiResponse> ReadChangeTrackingHeader();
        Task<ApiResponse> UpdateChangeTrackingHeader(ChangeTrackingHeaderModel ChangeTrackingHeaderModel, string userName);
        Task<ApiResponse> DeleteChangeTrackingHeader(int id, string userName);
        Task<ApiResponse> ReadChangeTrackingHeader(int id);
    }

    public class ChangeTrackingHeaderService : IChangeTrackingHeaderService
    {
        private readonly IChangeTrackingHeaderRepository _repository;
        private readonly IMapper _mapper;

        public ChangeTrackingHeaderService(IChangeTrackingHeaderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateChangeTrackingHeader(ChangeTrackingHeaderModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ChangeTrackingHeader>(model);
                await _repository.AddAsync(result, userName);
                model.IdChangeTrackingHeader = result.IdChangeTrackingHeader;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadChangeTrackingHeader()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ChangeTrackingHeaderModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateChangeTrackingHeader(ChangeTrackingHeaderModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdChangeTrackingHeader);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ChangeTrackingHeader>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteChangeTrackingHeader(int id, string userName)
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

        public async Task<ApiResponse> ReadChangeTrackingHeader(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ChangeTrackingHeaderModel>(model);

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

