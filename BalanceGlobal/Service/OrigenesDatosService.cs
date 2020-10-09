
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

    public interface IOrigenesDatosService
    {
        Task<ApiResponse> CreateOrigenesDatos(OrigenesDatosModel OrigenesDatosModel, string userName);
        Task<ApiResponse> ReadOrigenesDatos();
        Task<ApiResponse> UpdateOrigenesDatos(OrigenesDatosModel OrigenesDatosModel, string userName);
        Task<ApiResponse> DeleteOrigenesDatos(int id, string userName);
        Task<ApiResponse> ReadOrigenesDatos(int id);
    }

    public class OrigenesDatosService : IOrigenesDatosService
    {
        private readonly IOrigenesDatosRepository _repository;
        private readonly IMapper _mapper;

        public OrigenesDatosService(IOrigenesDatosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateOrigenesDatos(OrigenesDatosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<OrigenesDatos>(model);
                await _repository.AddAsync(result, userName);
                model.IdOrigenesDatos = result.IdOrigenesDatos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadOrigenesDatos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<OrigenesDatosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateOrigenesDatos(OrigenesDatosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdOrigenesDatos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<OrigenesDatos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteOrigenesDatos(int id, string userName)
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

        public async Task<ApiResponse> ReadOrigenesDatos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<OrigenesDatosModel>(model);

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

