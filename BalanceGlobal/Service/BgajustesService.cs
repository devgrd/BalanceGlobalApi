
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

    public interface IBgajustesService
    {
        Task<ApiResponse> CreateBgajustes(BgajustesModel BgajustesModel, string userName);
        Task<ApiResponse> ReadBgajustesByPeriodo(int idPeriodo);
        Task<ApiResponse> UpdateBgajustes(BgajustesModel BgajustesModel, string userName);
        Task<ApiResponse> DeleteBgajustes(int id, string userName);
        Task<ApiResponse> ReadBgajustes(int id);
    }

    public class BgajustesService : IBgajustesService
    {
        private readonly IBgajustesRepository _repository;
        private readonly IMapper _mapper;

        public BgajustesService(IBgajustesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateBgajustes(BgajustesModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Bgajustes>(model);
                await _repository.AddAsync(result, userName);
                model.IdBgajustes = result.IdBgajustes;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadBgajustesByPeriodo(int idPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == idPeriodo);
                var result = _mapper.Map<List<BgajustesModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateBgajustes(BgajustesModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdBgajustes);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Bgajustes>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteBgajustes(int id, string userName)
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

        public async Task<ApiResponse> ReadBgajustes(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<BgajustesModel>(model);

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

