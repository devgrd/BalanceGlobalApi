
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

    public interface IImpregnacionSistemaRefService
    {
        Task<ApiResponse> CreateImpregnacionSistemaRef(ImpregnacionSistemaRefModel ImpregnacionSistemaRefModel, string userName);
        Task<ApiResponse> ReadImpregnacionSistemaRef();
        Task<ApiResponse> UpdateImpregnacionSistemaRef(ImpregnacionSistemaRefModel ImpregnacionSistemaRefModel, string userName);
        Task<ApiResponse> DeleteImpregnacionSistemaRef(int id, string userName);
        Task<ApiResponse> ReadImpregnacionSistemaRef(int id);
    }

    public class ImpregnacionSistemaRefService : IImpregnacionSistemaRefService
    {
        private readonly IImpregnacionSistemaRefRepository _repository;
        private readonly IMapper _mapper;

        public ImpregnacionSistemaRefService(IImpregnacionSistemaRefRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateImpregnacionSistemaRef(ImpregnacionSistemaRefModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ImpregnacionSistemaRef>(model);
                await _repository.AddAsync(result, userName);
                model.IdImpregnacionSistemaRef = result.IdImpregnacionSistemaRef;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadImpregnacionSistemaRef()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ImpregnacionSistemaRefModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateImpregnacionSistemaRef(ImpregnacionSistemaRefModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdImpregnacionSistemaRef);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImpregnacionSistemaRef>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteImpregnacionSistemaRef(int id, string userName)
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

        public async Task<ApiResponse> ReadImpregnacionSistemaRef(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ImpregnacionSistemaRefModel>(model);

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
