using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IInfraestructurasService
    {
        Task CreateInfraestructuras(InfraestructurasEntity InfraestructurasEntity);
        Task<List<InfraestructurasEntity>> ReadInfraestructuras();
        Task UpdateInfraestructuras(InfraestructurasEntity InfraestructurasEntity);
        Task DeleteInfraestructuras(string id);
        Task<InfraestructurasEntity> ReadInfraestructuras(string id);
    }
    public class InfraestructurasService : IInfraestructurasService
    {
        private readonly IInfraestructurasRepository _repository;
        private readonly IMapper _mapper;

        public InfraestructurasService(IInfraestructurasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateInfraestructuras(InfraestructurasEntity entity)
        {
            var result = _mapper.Map<Infraestructuras>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<InfraestructurasEntity>> ReadInfraestructuras()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<InfraestructurasEntity>>(data);

            return result;
        }

        public async Task UpdateInfraestructuras(InfraestructurasEntity entity)
        {
            var result = _mapper.Map<Infraestructuras>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteInfraestructuras(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<InfraestructurasEntity> ReadInfraestructuras(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<InfraestructurasEntity>(entity);
            return result;
        }

        #endregion
    }
}