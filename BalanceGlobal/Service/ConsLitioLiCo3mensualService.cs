
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsLitioLiCo3mensualService
    {
        Task<ConsLitioLiCo3mensualModel> CreateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel ConsLitioLiCo3mensualModel, string userName);
        Task<List<ConsLitioLiCo3mensualModel>> ReadConsLitioLiCo3mensual();
        Task UpdateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel ConsLitioLiCo3mensualModel, string userName);
        Task DeleteConsLitioLiCo3mensual(int id, string userName);
        Task<ConsLitioLiCo3mensualModel> ReadConsLitioLiCo3mensual(int id);
    }
    public class ConsLitioLiCo3mensualService : IConsLitioLiCo3mensualService
    {
        private readonly IConsLitioLiCo3mensualRepository _repository;
        private readonly IMapper _mapper;

        public ConsLitioLiCo3mensualService(IConsLitioLiCo3mensualRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsLitioLiCo3mensualModel> CreateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel model, string userName)
        {
            var result = _mapper.Map<ConsLitioLiCo3mensual>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsLitioLiCo3mensual = result.IdConsLitioLiCo3mensual;
            return model;
        }

        public async Task<List<ConsLitioLiCo3mensualModel>> ReadConsLitioLiCo3mensual()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsLitioLiCo3mensualModel>>(data);

            return result;
        }

        public async Task UpdateConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel model, string userName)
        {
            var result = _mapper.Map<ConsLitioLiCo3mensual>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsLitioLiCo3mensual(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsLitioLiCo3mensualModel> ReadConsLitioLiCo3mensual(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsLitioLiCo3mensualModel>(model);
            return result;
        }

        #endregion
    }
}