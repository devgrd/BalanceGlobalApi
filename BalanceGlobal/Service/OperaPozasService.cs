using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IOperaPozasService
    {
        Task CreateOperaPozas(OperaPozasEntity OperaPozasEntity);
        Task<List<OperaPozasEntity>> ReadOperaPozas();
        Task UpdateOperaPozas(OperaPozasEntity OperaPozasEntity);
        Task DeleteOperaPozas(string id);
        Task<OperaPozasEntity> ReadOperaPozas(string id);
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

        public async Task CreateOperaPozas(OperaPozasEntity entity)
        {
            var result = _mapper.Map<OperaPozas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<OperaPozasEntity>> ReadOperaPozas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<OperaPozasEntity>>(data);

            return result;
        }

        public async Task UpdateOperaPozas(OperaPozasEntity entity)
        {
            var result = _mapper.Map<OperaPozas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteOperaPozas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<OperaPozasEntity> ReadOperaPozas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<OperaPozasEntity>(entity);
            return result;
        }

        #endregion
    }
}