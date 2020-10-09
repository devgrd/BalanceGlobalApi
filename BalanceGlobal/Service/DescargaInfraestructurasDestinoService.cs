
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

    public interface IDescargaInfraestructurasDestinoService
    {
        Task<ApiResponse> CreateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel DescargaInfraestructurasDestinoModel, string userName);
        Task<ApiResponse> ReadDescargaInfraestructurasDestino();
        Task<ApiResponse> UpdateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel DescargaInfraestructurasDestinoModel, string userName);
        Task<ApiResponse> DeleteDescargaInfraestructurasDestino(int id, string userName);
        Task<ApiResponse> ReadDescargaInfraestructurasDestino(int id);
    }

    public class DescargaInfraestructurasDestinoService : IDescargaInfraestructurasDestinoService
    {
        private readonly IDescargaInfraestructurasDestinoRepository _repository;
        private readonly IMapper _mapper;

        public DescargaInfraestructurasDestinoService(IDescargaInfraestructurasDestinoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<DescargaInfraestructurasDestino>(model);
                await _repository.AddAsync(result, userName);
                model.IdDescargaInfraestructurasDestino = result.IdDescargaInfraestructurasDestino;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadDescargaInfraestructurasDestino()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<DescargaInfraestructurasDestinoModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdDescargaInfraestructurasDestino);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DescargaInfraestructurasDestino>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteDescargaInfraestructurasDestino(int id, string userName)
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

        public async Task<ApiResponse> ReadDescargaInfraestructurasDestino(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DescargaInfraestructurasDestinoModel>(model);

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

