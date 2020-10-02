
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsDespachoService
    {
        Task<ConsDespachoModel> CreateConsDespacho(ConsDespachoModel ConsDespachoModel, string userName);
        Task<List<ConsDespachoModel>> ReadConsDespacho();
        Task UpdateConsDespacho(ConsDespachoModel ConsDespachoModel, string userName);
        Task DeleteConsDespacho(int id, string userName);
        Task<ConsDespachoModel> ReadConsDespacho(int id);
    }
    public class ConsDespachoService : IConsDespachoService
    {
        private readonly IConsDespachoRepository _repository;
        private readonly IMapper _mapper;

        public ConsDespachoService(IConsDespachoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsDespachoModel> CreateConsDespacho(ConsDespachoModel model, string userName)
        {
            var result = _mapper.Map<ConsDespacho>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsDespacho = result.IdConsDespacho;
            return model;
        }

        public async Task<List<ConsDespachoModel>> ReadConsDespacho()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsDespachoModel>>(data);

            return result;
        }

        public async Task UpdateConsDespacho(ConsDespachoModel model, string userName)
        {
            var result = _mapper.Map<ConsDespacho>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsDespacho(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsDespachoModel> ReadConsDespacho(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsDespachoModel>(model);
            return result;
        }

        #endregion
    }
}