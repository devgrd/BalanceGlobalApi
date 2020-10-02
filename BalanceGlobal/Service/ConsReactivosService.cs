
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsReactivosService
    {
        Task<ConsReactivosModel> CreateConsReactivos(ConsReactivosModel ConsReactivosModel, string userName);
        Task<List<ConsReactivosModel>> ReadConsReactivos();
        Task UpdateConsReactivos(ConsReactivosModel ConsReactivosModel, string userName);
        Task DeleteConsReactivos(int id, string userName);
        Task<ConsReactivosModel> ReadConsReactivos(int id);
    }
    public class ConsReactivosService : IConsReactivosService
    {
        private readonly IConsReactivosRepository _repository;
        private readonly IMapper _mapper;

        public ConsReactivosService(IConsReactivosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsReactivosModel> CreateConsReactivos(ConsReactivosModel model, string userName)
        {
            var result = _mapper.Map<ConsReactivos>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsReactivos = result.IdConsReactivos;
            return model;
        }

        public async Task<List<ConsReactivosModel>> ReadConsReactivos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsReactivosModel>>(data);

            return result;
        }

        public async Task UpdateConsReactivos(ConsReactivosModel model, string userName)
        {
            var result = _mapper.Map<ConsReactivos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsReactivos(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsReactivosModel> ReadConsReactivos(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsReactivosModel>(model);
            return result;
        }

        #endregion
    }
}