
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsumoAguaService
    {
        Task<ConsumoAguaModel> CreateConsumoAgua(ConsumoAguaModel ConsumoAguaModel, string userName);
        Task<List<ConsumoAguaModel>> ReadConsumoAgua();
        Task UpdateConsumoAgua(ConsumoAguaModel ConsumoAguaModel, string userName);
        Task DeleteConsumoAgua(int id, string userName);
        Task<ConsumoAguaModel> ReadConsumoAgua(int id);
    }
    public class ConsumoAguaService : IConsumoAguaService
    {
        private readonly IConsumoAguaRepository _repository;
        private readonly IMapper _mapper;

        public ConsumoAguaService(IConsumoAguaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsumoAguaModel> CreateConsumoAgua(ConsumoAguaModel model, string userName)
        {
            var result = _mapper.Map<ConsumoAgua>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsumoAgua = result.IdConsumoAgua;
            return model;
        }

        public async Task<List<ConsumoAguaModel>> ReadConsumoAgua()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsumoAguaModel>>(data);

            return result;
        }

        public async Task UpdateConsumoAgua(ConsumoAguaModel model, string userName)
        {
            var result = _mapper.Map<ConsumoAgua>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsumoAgua(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsumoAguaModel> ReadConsumoAgua(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsumoAguaModel>(model);
            return result;
        }

        #endregion
    }
}