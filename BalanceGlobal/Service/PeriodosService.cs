
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
        Task<PeriodosModel> CreatePeriodos(PeriodosModel PeriodosModel, string userName);
        Task<List<PeriodosModel>> ReadPeriodos();
        Task UpdatePeriodos(PeriodosModel PeriodosModel, string userName);
        Task DeletePeriodos(int id, string userName);
        Task<PeriodosModel> ReadPeriodos(int id);
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

        public async Task<PeriodosModel> CreatePeriodos(PeriodosModel model, string userName)
        {
            var result = _mapper.Map<Periodos>(model);
            await _repository.AddAsync(result, userName);
            model.IdPeriodos = result.IdPeriodos;
            return model;
        }

        public async Task<List<PeriodosModel>> ReadPeriodos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PeriodosModel>>(data);

            return result;
        }

        public async Task UpdatePeriodos(PeriodosModel model, string userName)
        {
            var result = _mapper.Map<Periodos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeletePeriodos(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<PeriodosModel> ReadPeriodos(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PeriodosModel>(model);
            return result;
        }

        #endregion
    }
}