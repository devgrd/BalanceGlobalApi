
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITipoInfraestructurasService
    {
        Task<TipoInfraestructurasModel> CreateTipoInfraestructuras(TipoInfraestructurasModel TipoInfraestructurasModel);
        Task<List<TipoInfraestructurasModel>> ReadTipoInfraestructuras();
        Task UpdateTipoInfraestructuras(TipoInfraestructurasModel TipoInfraestructurasModel);
        Task DeleteTipoInfraestructuras(string id);
        Task<TipoInfraestructurasModel> ReadTipoInfraestructuras(string id);
    }
    public class TipoInfraestructurasService : ITipoInfraestructurasService
    {
        private readonly ITipoInfraestructurasRepository _repository;
        private readonly IMapper _mapper;

        public TipoInfraestructurasService(ITipoInfraestructurasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<TipoInfraestructurasModel> CreateTipoInfraestructuras(TipoInfraestructurasModel model)
        {
            var result = _mapper.Map<TipoInfraestructuras>(model);
            await _repository.AddAsync(result);
            model.IdTipoInfraestructuras = result.IdTipoInfraestructuras;
            return model;
        }

        public async Task<List<TipoInfraestructurasModel>> ReadTipoInfraestructuras()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TipoInfraestructurasModel>>(data);

            return result;
        }

        public async Task UpdateTipoInfraestructuras(TipoInfraestructurasModel model)
        {
            var result = _mapper.Map<TipoInfraestructuras>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteTipoInfraestructuras(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<TipoInfraestructurasModel> ReadTipoInfraestructuras(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TipoInfraestructurasModel>(model);
            return result;
        }

        #endregion
    }
}