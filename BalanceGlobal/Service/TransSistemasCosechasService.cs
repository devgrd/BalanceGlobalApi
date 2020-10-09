
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

    public interface ITransSistemasCosechasService
    {
        Task<ApiResponse> CreateTransSistemasCosechas(TransSistemasCosechasModel TransSistemasCosechasModel, string userName);
        Task<ApiResponse> ReadTransSistemasCosechas();
        Task<ApiResponse> UpdateTransSistemasCosechas(TransSistemasCosechasModel TransSistemasCosechasModel, string userName);
        Task<ApiResponse> DeleteTransSistemasCosechas(int id, string userName);
        Task<ApiResponse> ReadTransSistemasCosechas(int id);
    }

    public class TransSistemasCosechasService : ITransSistemasCosechasService
    {
        private readonly ITransSistemasCosechasRepository _repository;
        private readonly IMapper _mapper;

        public TransSistemasCosechasService(ITransSistemasCosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateTransSistemasCosechas(TransSistemasCosechasModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<TransSistemasCosechas>(model);
                await _repository.AddAsync(result, userName);
                model.IdTransSistemasCosechas = result.IdTransSistemasCosechas;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadTransSistemasCosechas()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<TransSistemasCosechasModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateTransSistemasCosechas(TransSistemasCosechasModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdTransSistemasCosechas);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TransSistemasCosechas>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteTransSistemasCosechas(int id, string userName)
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

        public async Task<ApiResponse> ReadTransSistemasCosechas(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<TransSistemasCosechasModel>(model);

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

