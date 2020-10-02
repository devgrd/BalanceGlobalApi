
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsumoEnergeticoService
    {
        Task<ConsumoEnergeticoModel> CreateConsumoEnergetico(ConsumoEnergeticoModel ConsumoEnergeticoModel, string userName);
        Task<List<ConsumoEnergeticoModel>> ReadConsumoEnergetico();
        Task UpdateConsumoEnergetico(ConsumoEnergeticoModel ConsumoEnergeticoModel, string userName);
        Task DeleteConsumoEnergetico(int id, string userName);
        Task<ConsumoEnergeticoModel> ReadConsumoEnergetico(int id);
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

        public async Task<ConsumoEnergeticoModel> CreateConsumoEnergetico(ConsumoEnergeticoModel model, string userName)
        {
            var result = _mapper.Map<ConsumoEnergetico>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsumoEnergetico = result.IdConsumoEnergetico;
            return model;
        }

        public async Task<List<ConsumoEnergeticoModel>> ReadConsumoEnergetico()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsumoEnergeticoModel>>(data);

            return result;
        }

        public async Task UpdateConsumoEnergetico(ConsumoEnergeticoModel model, string userName)
        {
            var result = _mapper.Map<ConsumoEnergetico>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsumoEnergetico(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsumoEnergeticoModel> ReadConsumoEnergetico(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsumoEnergeticoModel>(model);
            return result;
        }

        #endregion
    }
}