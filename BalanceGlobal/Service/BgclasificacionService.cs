
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

    public interface IBgclasificacionService
    {
        Task<ApiResponse> CreateBgclasificacion(BgclasificacionModel BgclasificacionModel, string userName);
        Task<ApiResponse> ReadBgclasificacion();
        Task<ApiResponse> UpdateBgclasificacion(BgclasificacionModel BgclasificacionModel, string userName);
        Task<ApiResponse> DeleteBgclasificacion(int id, string userName);
        Task<ApiResponse> ReadBgclasificacion(int id);
    }

    public class BgclasificacionService : IBgclasificacionService
    {
        private readonly IBgclasificacionRepository _repository;
        private readonly IMapper _mapper;

        public BgclasificacionService(IBgclasificacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateBgclasificacion(BgclasificacionModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Bgclasificacion>(model);
                await _repository.AddAsync(result, userName);
                model.IdBgclasificacion = result.IdBgclasificacion;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadBgclasificacion()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<BgclasificacionModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateBgclasificacion(BgclasificacionModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdBgclasificacion);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Bgclasificacion>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteBgclasificacion(int id, string userName)
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

        public async Task<ApiResponse> ReadBgclasificacion(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<BgclasificacionModel>(model);

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

