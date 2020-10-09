
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

    public interface IEventosService
    {
        Task<ApiResponse> CreateEventos(EventosModel EventosModel, string userName);
        Task<ApiResponse> ReadEventos();
        Task<ApiResponse> UpdateEventos(EventosModel EventosModel, string userName);
        Task<ApiResponse> DeleteEventos(int id, string userName);
        Task<ApiResponse> ReadEventos(int id);
    }

    public class EventosService : IEventosService
    {
        private readonly IEventosRepository _repository;
        private readonly IMapper _mapper;

        public EventosService(IEventosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateEventos(EventosModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<Eventos>(model);
                await _repository.AddAsync(result, userName);
                model.IdEventos = result.IdEventos;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadEventos()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<EventosModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateEventos(EventosModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdEventos);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<Eventos>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteEventos(int id, string userName)
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

        public async Task<ApiResponse> ReadEventos(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<EventosModel>(model);

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

