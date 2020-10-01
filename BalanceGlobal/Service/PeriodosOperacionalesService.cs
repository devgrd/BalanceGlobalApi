
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPeriodosOperacionalesService
    {
        Task<PeriodosOperacionalesModel> CreatePeriodosOperacionales(PeriodosOperacionalesModel PeriodosOperacionalesModel);
        Task<List<PeriodosOperacionalesModel>> ReadPeriodosOperacionales();
        Task UpdatePeriodosOperacionales(PeriodosOperacionalesModel PeriodosOperacionalesModel);
        Task DeletePeriodosOperacionales(string id);
        Task<PeriodosOperacionalesModel> ReadPeriodosOperacionales(string id);
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

        public async Task<PeriodosOperacionalesModel> CreatePeriodosOperacionales(PeriodosOperacionalesModel model)
        {
            var result = _mapper.Map<PeriodosOperacionales>(model);
            await _repository.AddAsync(result);
            model.IdPeriodosOperacionales = result.IdPeriodosOperacionales;
            return model;
        }

        public async Task<List<PeriodosOperacionalesModel>> ReadPeriodosOperacionales()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PeriodosOperacionalesModel>>(data);

            return result;
        }

        public async Task UpdatePeriodosOperacionales(PeriodosOperacionalesModel model)
        {
            var result = _mapper.Map<PeriodosOperacionales>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeletePeriodosOperacionales(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<PeriodosOperacionalesModel> ReadPeriodosOperacionales(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PeriodosOperacionalesModel>(model);
            return result;
        }

        #endregion
    }
}