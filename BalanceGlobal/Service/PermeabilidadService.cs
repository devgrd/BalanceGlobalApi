
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

    public interface IPermeabilidadService
    {
        Task<ApiResponse> CreatePermeabilidad(PermeabilidadModel PermeabilidadModel, string userName);
        Task<ApiResponse> ReadPermeabilidad();
        Task<ApiResponse> UpdatePermeabilidad(PermeabilidadModel PermeabilidadModel, string userName);
        Task<ApiResponse> DeletePermeabilidad(int id, string userName);
        Task<ApiResponse> ReadPermeabilidad(int id);
    }

    public class PermeabilidadService : IPermeabilidadService
    {
        private readonly IPermeabilidadRepository _repository;
        private readonly IMapper _mapper;

        public PermeabilidadService(IPermeabilidadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePermeabilidad(PermeabilidadModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Permeabilidad>(model);
                await _repository.AddAsync(result, userName);
                model.IdPermeabilidad = result.IdPermeabilidad;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPermeabilidad()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PermeabilidadModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdatePermeabilidad(PermeabilidadModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPermeabilidad);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Permeabilidad>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePermeabilidad(int id, string userName)
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

        public async Task<ApiResponse> ReadPermeabilidad(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PermeabilidadModel>(model);

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

