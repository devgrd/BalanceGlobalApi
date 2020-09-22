using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPeriodosOperacionalesService
    {
        Task CreatePeriodosOperacionales(PeriodosOperacionalesEntity PeriodosOperacionalesEntity);
        Task<List<PeriodosOperacionalesEntity>> ReadPeriodosOperacionales();
        Task UpdatePeriodosOperacionales(PeriodosOperacionalesEntity PeriodosOperacionalesEntity);
        Task DeletePeriodosOperacionales(string id);
        Task<PeriodosOperacionalesEntity> ReadPeriodosOperacionales(string id);
    }
    public class PeriodosOperacionalesService : IPeriodosOperacionalesService
    {
        private readonly IPeriodosOperacionalesRepository _repository;
        private readonly IMapper _mapper;

        public PeriodosOperacionalesService(IPeriodosOperacionalesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreatePeriodosOperacionales(PeriodosOperacionalesEntity entity)
        {
            var result = _mapper.Map<PeriodosOperacionales>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<PeriodosOperacionalesEntity>> ReadPeriodosOperacionales()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PeriodosOperacionalesEntity>>(data);

            return result;
        }

        public async Task UpdatePeriodosOperacionales(PeriodosOperacionalesEntity entity)
        {
            var result = _mapper.Map<PeriodosOperacionales>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeletePeriodosOperacionales(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<PeriodosOperacionalesEntity> ReadPeriodosOperacionales(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<PeriodosOperacionalesEntity>(entity);
            return result;
        }

        #endregion
    }
}