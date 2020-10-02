
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IInventariosAtacamaService
    {
        Task<InventariosAtacamaModel> CreateInventariosAtacama(InventariosAtacamaModel InventariosAtacamaModel, string userName);
        Task<List<InventariosAtacamaModel>> ReadInventariosAtacama();
        Task UpdateInventariosAtacama(InventariosAtacamaModel InventariosAtacamaModel, string userName);
        Task DeleteInventariosAtacama(int id, string userName);
        Task<InventariosAtacamaModel> ReadInventariosAtacama(int id);
    }
    public class InventariosAtacamaService : IInventariosAtacamaService
    {
        private readonly IInventariosAtacamaRepository _repository;
        private readonly IMapper _mapper;

        public InventariosAtacamaService(IInventariosAtacamaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<InventariosAtacamaModel> CreateInventariosAtacama(InventariosAtacamaModel model, string userName)
        {
            var result = _mapper.Map<InventariosAtacama>(model);
            await _repository.AddAsync(result, userName);
            model.IdInventariosAtacama = result.IdInventariosAtacama;
            return model;
        }

        public async Task<List<InventariosAtacamaModel>> ReadInventariosAtacama()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<InventariosAtacamaModel>>(data);

            return result;
        }

        public async Task UpdateInventariosAtacama(InventariosAtacamaModel model, string userName)
        {
            var result = _mapper.Map<InventariosAtacama>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteInventariosAtacama(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<InventariosAtacamaModel> ReadInventariosAtacama(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<InventariosAtacamaModel>(model);
            return result;
        }

        #endregion
    }
}