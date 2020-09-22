using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPeriodosService
    {
        Task CreatePeriodos(PeriodosEntity PeriodosEntity);
        Task<List<PeriodosEntity>> ReadPeriodos();
        Task UpdatePeriodos(PeriodosEntity PeriodosEntity);
        Task DeletePeriodos(string id);
        Task<PeriodosEntity> ReadPeriodos(string id);
    }
    public class PeriodosService : IPeriodosService
    {
        private readonly IPeriodosRepository _repository;
        private readonly IMapper _mapper;

        public PeriodosService(IPeriodosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreatePeriodos(PeriodosEntity entity)
        {
            var result = _mapper.Map<Periodos>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<PeriodosEntity>> ReadPeriodos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PeriodosEntity>>(data);

            return result;
        }

        public async Task UpdatePeriodos(PeriodosEntity entity)
        {
            var result = _mapper.Map<Periodos>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeletePeriodos(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<PeriodosEntity> ReadPeriodos(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<PeriodosEntity>(entity);
            return result;
        }

        #endregion
    }
}