
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

    public interface IDatosEnListaService
    {
        Task<ApiResponse> CreateDatosEnLista(DatosEnListaModel DatosEnListaModel, string userName);
        Task<ApiResponse> ReadDatosEnLista();
        Task<ApiResponse> UpdateDatosEnLista(DatosEnListaModel DatosEnListaModel, string userName);
        Task<ApiResponse> DeleteDatosEnLista(int id, string userName);
        Task<ApiResponse> ReadDatosEnLista(int id);
    }

    public class DatosEnListaService : IDatosEnListaService
    {
        private readonly IDatosEnListaRepository _repository;
        private readonly IMapper _mapper;

        public DatosEnListaService(IDatosEnListaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateDatosEnLista(DatosEnListaModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<DatosEnLista>(model);
                await _repository.AddAsync(result, userName);
                model.IdDatosEnLista = result.IdDatosEnLista;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadDatosEnLista()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<DatosEnListaModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateDatosEnLista(DatosEnListaModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdDatosEnLista);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DatosEnLista>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteDatosEnLista(int id, string userName)
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

        public async Task<ApiResponse> ReadDatosEnLista(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<DatosEnListaModel>(model);

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

