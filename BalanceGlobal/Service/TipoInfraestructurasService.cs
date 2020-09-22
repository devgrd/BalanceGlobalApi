using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITipoInfraestructurasService
    {
        Task CreateTipoInfraestructuras(TipoInfraestructurasEntity TipoInfraestructurasEntity);
        Task<List<TipoInfraestructurasEntity>> ReadTipoInfraestructuras();
        Task UpdateTipoInfraestructuras(TipoInfraestructurasEntity TipoInfraestructurasEntity);
        Task DeleteTipoInfraestructuras(string id);
        Task<TipoInfraestructurasEntity> ReadTipoInfraestructuras(string id);
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

        public async Task CreateTipoInfraestructuras(TipoInfraestructurasEntity entity)
        {
            var result = _mapper.Map<TipoInfraestructuras>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<TipoInfraestructurasEntity>> ReadTipoInfraestructuras()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TipoInfraestructurasEntity>>(data);

            return result;
        }

        public async Task UpdateTipoInfraestructuras(TipoInfraestructurasEntity entity)
        {
            var result = _mapper.Map<TipoInfraestructuras>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteTipoInfraestructuras(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<TipoInfraestructurasEntity> ReadTipoInfraestructuras(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<TipoInfraestructurasEntity>(entity);
            return result;
        }

        #endregion
    }
}