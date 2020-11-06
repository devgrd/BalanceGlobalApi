
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

    public interface IRiegoPlataformasService
    {
        Task<ApiResponse> CreateRiegoPlataformas(RiegoPlataformasModel RiegoPlataformasModel, string userName);
        Task<ApiResponse> ReadRiegoPlataformasByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateRiegoPlataformas(RiegoPlataformasModel RiegoPlataformasModel, string userName);
        Task<ApiResponse> DeleteRiegoPlataformas(int id, string userName);
        Task<ApiResponse> ReadRiegoPlataformas(int id);
    }

    public class RiegoPlataformasService : IRiegoPlataformasService
    {
        private readonly IRiegoPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public RiegoPlataformasService(IRiegoPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateRiegoPlataformas(RiegoPlataformasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<RiegoPlataformas>(model);
                await _repository.AddAsync(result, userName);
                model.IdRiegoPlataformas = result.IdRiegoPlataformas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadRiegoPlataformasByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<RiegoPlataformasModel>>(data);

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

        public async Task<ApiResponse> UpdateRiegoPlataformas(RiegoPlataformasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdRiegoPlataformas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<RiegoPlataformas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteRiegoPlataformas(int id, string userName)
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

        public async Task<ApiResponse> ReadRiegoPlataformas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<RiegoPlataformasModel>(model);

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

