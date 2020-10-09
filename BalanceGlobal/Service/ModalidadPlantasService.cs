
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

    public interface IModalidadPlantasService
    {
        Task<ApiResponse> CreateModalidadPlantas(ModalidadPlantasModel ModalidadPlantasModel, string userName);
        Task<ApiResponse> ReadModalidadPlantas();
        Task<ApiResponse> UpdateModalidadPlantas(ModalidadPlantasModel ModalidadPlantasModel, string userName);
        Task<ApiResponse> DeleteModalidadPlantas(int id, string userName);
        Task<ApiResponse> ReadModalidadPlantas(int id);
    }

    public class ModalidadPlantasService : IModalidadPlantasService
    {
        private readonly IModalidadPlantasRepository _repository;
        private readonly IMapper _mapper;

        public ModalidadPlantasService(IModalidadPlantasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateModalidadPlantas(ModalidadPlantasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ModalidadPlantas>(model);
                await _repository.AddAsync(result, userName);
                model.IdModalidadPlantas = result.IdModalidadPlantas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadModalidadPlantas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ModalidadPlantasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateModalidadPlantas(ModalidadPlantasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdModalidadPlantas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ModalidadPlantas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteModalidadPlantas(int id, string userName)
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

        public async Task<ApiResponse> ReadModalidadPlantas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ModalidadPlantasModel>(model);

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

