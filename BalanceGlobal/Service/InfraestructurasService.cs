
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

    public interface IInfraestructurasService
    {
        Task<ApiResponse> CreateInfraestructuras(InfraestructurasModel InfraestructurasModel, string userName);
        Task<ApiResponse> ReadInfraestructuras();
        Task<ApiResponse> UpdateInfraestructuras(InfraestructurasModel InfraestructurasModel, string userName);
        Task<ApiResponse> DeleteInfraestructuras(int id, string userName);
        Task<ApiResponse> ReadInfraestructuras(int id);
    }

    public class InfraestructurasService : IInfraestructurasService
    {
        private readonly IInfraestructurasRepository _repository;
        private readonly IMapper _mapper;

        public InfraestructurasService(IInfraestructurasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateInfraestructuras(InfraestructurasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Infraestructuras>(model);
                await _repository.AddAsync(result, userName);
                model.IdInfraestructuras = result.IdInfraestructuras;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadInfraestructuras()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<InfraestructurasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateInfraestructuras(InfraestructurasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdInfraestructuras);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Infraestructuras>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteInfraestructuras(int id, string userName)
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

        public async Task<ApiResponse> ReadInfraestructuras(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<InfraestructurasModel>(model);

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

