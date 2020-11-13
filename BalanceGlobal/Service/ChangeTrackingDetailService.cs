
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

    public interface IChangeTrackingDetailService
    {
        Task<ApiResponse> CreateChangeTrackingDetail(ChangeTrackingDetailModel ChangeTrackingDetailModel, string userName);
        Task<ApiResponse> ReadChangeTrackingDetail();
        Task<ApiResponse> UpdateChangeTrackingDetail(ChangeTrackingDetailModel ChangeTrackingDetailModel, string userName);
        Task<ApiResponse> DeleteChangeTrackingDetail(int id, string userName);
        Task<ApiResponse> ReadChangeTrackingDetail(int id);
    }

    public class ChangeTrackingDetailService : IChangeTrackingDetailService
    {
        private readonly IChangeTrackingDetailRepository _repository;
        private readonly IMapper _mapper;

        public ChangeTrackingDetailService(IChangeTrackingDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateChangeTrackingDetail(ChangeTrackingDetailModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ChangeTrackingDetail>(model);
                await _repository.AddAsync(result, userName);
                model.IdChangeTrackingDetail = result.IdChangeTrackingDetail;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadChangeTrackingDetail()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ChangeTrackingDetailModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateChangeTrackingDetail(ChangeTrackingDetailModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdChangeTrackingDetail);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ChangeTrackingDetail>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteChangeTrackingDetail(int id, string userName)
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

        public async Task<ApiResponse> ReadChangeTrackingDetail(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ChangeTrackingDetailModel>(model);

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

