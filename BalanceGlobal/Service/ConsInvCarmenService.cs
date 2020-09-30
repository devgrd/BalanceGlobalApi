
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsInvCarmenService
    {
        Task<ConsInvCarmenModel> CreateConsInvCarmen(ConsInvCarmenModel ConsInvCarmenModel, string userName);
        Task<List<ConsInvCarmenModel>> ReadConsInvCarmen();
        Task UpdateConsInvCarmen(ConsInvCarmenModel ConsInvCarmenModel, string userName);
        Task DeleteConsInvCarmen(string id, string userName);
        Task<ConsInvCarmenModel> ReadConsInvCarmen(string id);
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

        public async Task<ConsInvCarmenModel> CreateConsInvCarmen(ConsInvCarmenModel model, string userName)
        {
            var result = _mapper.Map<ConsInvCarmen>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsInvCarmen = result.IdConsInvCarmen;
            return model;
        }

        public async Task<List<ConsInvCarmenModel>> ReadConsInvCarmen()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsInvCarmenModel>>(data);

            return result;
        }

        public async Task UpdateConsInvCarmen(ConsInvCarmenModel model, string userName)
        {
            var result = _mapper.Map<ConsInvCarmen>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsInvCarmen(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsInvCarmenModel> ReadConsInvCarmen(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsInvCarmenModel>(model);
            return result;
        }

        #endregion
    }
}