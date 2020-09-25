
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IReinyeccionService
    {
        Task<ReinyeccionModel> CreateReinyeccion(ReinyeccionModel ReinyeccionModel);
        Task<List<ReinyeccionModel>> ReadReinyeccion();
        Task UpdateReinyeccion(ReinyeccionModel ReinyeccionModel);
        Task DeleteReinyeccion(string id);
        Task<ReinyeccionModel> ReadReinyeccion(string id);
    }
    public class ReinyeccionService : IReinyeccionService
    {
        private readonly IReinyeccionRepository _repository;
        private readonly IMapper _mapper;

        public ReinyeccionService(IReinyeccionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ReinyeccionModel> CreateReinyeccion(ReinyeccionModel model)
        {
            var result = _mapper.Map<Reinyeccion>(model);
            await _repository.AddAsync(result);
            model.IdReinyeccion = result.IdReinyeccion;
            return model;
        }

        public async Task<List<ReinyeccionModel>> ReadReinyeccion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ReinyeccionModel>>(data);

            return result;
        }

        public async Task UpdateReinyeccion(ReinyeccionModel model)
        {
            var result = _mapper.Map<Reinyeccion>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteReinyeccion(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ReinyeccionModel> ReadReinyeccion(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ReinyeccionModel>(model);
            return result;
        }

        #endregion
    }
}