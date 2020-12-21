
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

    public interface IBgtiposService
    {
        Task<ApiResponse> CreateBgtipos(BgtiposModel BgtiposModel, string userName);
        Task<ApiResponse> ReadBgtipos();
        Task<ApiResponse> UpdateBgtipos(BgtiposModel BgtiposModel, string userName);
        Task<ApiResponse> DeleteBgtipos(int id, string userName);
        Task<ApiResponse> ReadBgtipos(int id);
    }

    public class BgtiposService : IBgtiposService
    {
        private readonly IBgtiposRepository _repository;
        private readonly IMapper _mapper;

        public BgtiposService(IBgtiposRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateBgtipos(BgtiposModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Bgtipos>(model);
                await _repository.AddAsync(result, userName);
                model.IdBgtipos = result.IdBgtipos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadBgtipos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<BgtiposModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateBgtipos(BgtiposModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdBgtipos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Bgtipos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteBgtipos(int id, string userName)
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

        public async Task<ApiResponse> ReadBgtipos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<BgtiposModel>(model);

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

