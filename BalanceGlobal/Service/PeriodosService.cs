
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPeriodosService
    {
        Task<PeriodosModel> CreatePeriodos(PeriodosModel PeriodosModel);
        Task<List<PeriodosModel>> ReadPeriodos();
        Task UpdatePeriodos(PeriodosModel PeriodosModel);
        Task DeletePeriodos(string id);
        Task<PeriodosModel> ReadPeriodos(string id);
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

        public async Task<PeriodosModel> CreatePeriodos(PeriodosModel model)
        {
            var result = _mapper.Map<Periodos>(model);
            await _repository.AddAsync(result);
            model.IdPeriodos = result.IdPeriodos;
            return model;
        }

        public async Task<List<PeriodosModel>> ReadPeriodos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PeriodosModel>>(data);

            return result;
        }

        public async Task UpdatePeriodos(PeriodosModel model)
        {
            var result = _mapper.Map<Periodos>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeletePeriodos(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<PeriodosModel> ReadPeriodos(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PeriodosModel>(model);
            return result;
        }

        #endregion
    }
}