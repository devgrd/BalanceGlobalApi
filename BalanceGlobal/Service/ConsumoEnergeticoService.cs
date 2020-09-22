using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsumoEnergeticoService
    {
        Task CreateConsumoEnergetico(ConsumoEnergeticoEntity ConsumoEnergeticoEntity);
        Task<List<ConsumoEnergeticoEntity>> ReadConsumoEnergetico();
        Task UpdateConsumoEnergetico(ConsumoEnergeticoEntity ConsumoEnergeticoEntity);
        Task DeleteConsumoEnergetico(string id);
        Task<ConsumoEnergeticoEntity> ReadConsumoEnergetico(string id);
    }
    public class ConsumoEnergeticoService : IConsumoEnergeticoService
    {
        private readonly IConsumoEnergeticoRepository _repository;
        private readonly IMapper _mapper;

        public ConsumoEnergeticoService(IConsumoEnergeticoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateConsumoEnergetico(ConsumoEnergeticoEntity entity)
        {
            var result = _mapper.Map<ConsumoEnergetico>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ConsumoEnergeticoEntity>> ReadConsumoEnergetico()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsumoEnergeticoEntity>>(data);

            return result;
        }

        public async Task UpdateConsumoEnergetico(ConsumoEnergeticoEntity entity)
        {
            var result = _mapper.Map<ConsumoEnergetico>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteConsumoEnergetico(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ConsumoEnergeticoEntity> ReadConsumoEnergetico(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ConsumoEnergeticoEntity>(entity);
            return result;
        }

        #endregion
    }
}