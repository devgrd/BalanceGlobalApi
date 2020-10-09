
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

    public interface IModalidadPciService
    {
        Task<ApiResponse> CreateModalidadPci(ModalidadPciModel ModalidadPciModel, string userName);
        Task<ApiResponse> ReadModalidadPci();
        Task<ApiResponse> UpdateModalidadPci(ModalidadPciModel ModalidadPciModel, string userName);
        Task<ApiResponse> DeleteModalidadPci(int id, string userName);
        Task<ApiResponse> ReadModalidadPci(int id);
    }

    public class ModalidadPciService : IModalidadPciService
    {
        private readonly IModalidadPciRepository _repository;
        private readonly IMapper _mapper;

        public ModalidadPciService(IModalidadPciRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateModalidadPci(ModalidadPciModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ModalidadPci>(model);
                await _repository.AddAsync(result, userName);
                model.IdModalidadPci = result.IdModalidadPci;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadModalidadPci()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<ModalidadPciModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateModalidadPci(ModalidadPciModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdModalidadPci);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ModalidadPci>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteModalidadPci(int id, string userName)
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

        public async Task<ApiResponse> ReadModalidadPci(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ModalidadPciModel>(model);

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

