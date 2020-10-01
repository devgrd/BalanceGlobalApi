
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IOperaPozasService
    {
        Task<OperaPozasModel> CreateOperaPozas(OperaPozasModel OperaPozasModel);
        Task<List<OperaPozasModel>> ReadOperaPozas();
        Task UpdateOperaPozas(OperaPozasModel OperaPozasModel);
        Task DeleteOperaPozas(string id);
        Task<OperaPozasModel> ReadOperaPozas(string id);
    }
    public class OperaPozasService : IOperaPozasService
    {
        private readonly IOperaPozasRepository _repository;
        private readonly IMapper _mapper;

        public OperaPozasService(IOperaPozasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<OperaPozasModel> CreateOperaPozas(OperaPozasModel model)
        {
            var result = _mapper.Map<OperaPozas>(model);
            await _repository.AddAsync(result);
            model.IdOperaPozas = result.IdOperaPozas;
            return model;
        }

        public async Task<List<OperaPozasModel>> ReadOperaPozas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<OperaPozasModel>>(data);

            return result;
        }

        public async Task UpdateOperaPozas(OperaPozasModel model)
        {
            var result = _mapper.Map<OperaPozas>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteOperaPozas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<OperaPozasModel> ReadOperaPozas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<OperaPozasModel>(model);
            return result;
        }

        #endregion
    }
}