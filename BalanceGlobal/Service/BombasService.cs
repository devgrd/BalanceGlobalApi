using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IBombasService
    {
        Task CreateBombas(BombasEntity BombasEntity);
        Task<List<BombasEntity>> ReadBombas();
        Task UpdateBombas(BombasEntity BombasEntity);
        Task DeleteBombas(string id);
        Task<BombasEntity> ReadBombas(string id);
    }
    public class BombasService : IBombasService
    {
        private readonly IBombasRepository _repository;
        private readonly IMapper _mapper;

        public BombasService(IBombasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateBombas(BombasEntity entity)
        {
            var result = _mapper.Map<Bombas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<BombasEntity>> ReadBombas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<BombasEntity>>(data);

            return result;
        }

        public async Task UpdateBombas(BombasEntity entity)
        {
            var result = _mapper.Map<Bombas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteBombas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<BombasEntity> ReadBombas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<BombasEntity>(entity);
            return result;
        }

        #endregion
    }
}