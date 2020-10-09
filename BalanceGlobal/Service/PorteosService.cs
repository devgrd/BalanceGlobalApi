
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

    public interface IPorteosService
    {
        Task<ApiResponse> CreatePorteos(PorteosModel PorteosModel, string userName);
        Task<ApiResponse> ReadPorteos();
        Task<ApiResponse> UpdatePorteos(PorteosModel PorteosModel, string userName);
        Task<ApiResponse> DeletePorteos(int id, string userName);
        Task<ApiResponse> ReadPorteos(int id);
    }

    public class PorteosService : IPorteosService
    {
        private readonly IPorteosRepository _repository;
        private readonly IMapper _mapper;

        public PorteosService(IPorteosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreatePorteos(PorteosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Porteos>(model);
                await _repository.AddAsync(result, userName);
                model.IdPorteos = result.IdPorteos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadPorteos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<PorteosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdatePorteos(PorteosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdPorteos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Porteos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeletePorteos(int id, string userName)
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

        public async Task<ApiResponse> ReadPorteos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<PorteosModel>(model);

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

