using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsInvCarmenService
    {
        Task CreateConsInvCarmen(ConsInvCarmenEntity ConsInvCarmenEntity);
        Task<List<ConsInvCarmenEntity>> ReadConsInvCarmen();
        Task UpdateConsInvCarmen(ConsInvCarmenEntity ConsInvCarmenEntity);
        Task DeleteConsInvCarmen(string id);
        Task<ConsInvCarmenEntity> ReadConsInvCarmen(string id);
    }
    public class ConsInvCarmenService : IConsInvCarmenService
    {
        private readonly IConsInvCarmenRepository _repository;
        private readonly IMapper _mapper;

        public ConsInvCarmenService(IConsInvCarmenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateConsInvCarmen(ConsInvCarmenEntity entity)
        {
            var result = _mapper.Map<ConsInvCarmen>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ConsInvCarmenEntity>> ReadConsInvCarmen()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsInvCarmenEntity>>(data);

            return result;
        }

        public async Task UpdateConsInvCarmen(ConsInvCarmenEntity entity)
        {
            var result = _mapper.Map<ConsInvCarmen>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteConsInvCarmen(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ConsInvCarmenEntity> ReadConsInvCarmen(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ConsInvCarmenEntity>(entity);
            return result;
        }

        #endregion
    }
}