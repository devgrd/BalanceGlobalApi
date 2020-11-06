
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

    public interface IConsPlantaLiOhService
    {
        Task<ApiResponse> CreateConsPlantaLiOh(ConsPlantaLiOhModel ConsPlantaLiOhModel, string userName);
        Task<ApiResponse> ReadConsPlantaLiOhByPeriodos(int IdPeriodo);
        Task<ApiResponse> UpdateConsPlantaLiOh(ConsPlantaLiOhModel ConsPlantaLiOhModel, string userName);
        Task<ApiResponse> DeleteConsPlantaLiOh(int id, string userName);
        Task<ApiResponse> ReadConsPlantaLiOh(int id);
    }

    public class ConsPlantaLiOhService : IConsPlantaLiOhService
    {
        private readonly IConsPlantaLiOhRepository _repository;
        private readonly IMapper _mapper;

        public ConsPlantaLiOhService(IConsPlantaLiOhRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateConsPlantaLiOh(ConsPlantaLiOhModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<ConsPlantaLiOh>(model);
                await _repository.AddAsync(result, userName);
                model.IdConsPlantaLiOh = result.IdConsPlantaLiOh;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadConsPlantaLiOhByPeriodos(int IdPeriodo)
        {
            try
            {
                var data = await _repository.GetManyAsync(x => x.IdPeriodos == IdPeriodo);
                var result = _mapper.Map<List<ConsPlantaLiOhModel>>(data);

                if (result.Count == 0)
                {
                    return new ApiResponse("Not Found", 404);
                }

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateConsPlantaLiOh(ConsPlantaLiOhModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdConsPlantaLiOh);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsPlantaLiOh>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteConsPlantaLiOh(int id, string userName)
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

        public async Task<ApiResponse> ReadConsPlantaLiOh(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<ConsPlantaLiOhModel>(model);

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

