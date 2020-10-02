
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsLi2Co3Service
    {
        Task<ConsLi2Co3Model> CreateConsLi2Co3(ConsLi2Co3Model ConsLi2Co3Model, string userName);
        Task<List<ConsLi2Co3Model>> ReadConsLi2Co3();
        Task UpdateConsLi2Co3(ConsLi2Co3Model ConsLi2Co3Model, string userName);
        Task DeleteConsLi2Co3(int id, string userName);
        Task<ConsLi2Co3Model> ReadConsLi2Co3(int id);
    }
    public class ConsLi2Co3Service : IConsLi2Co3Service
    {
        private readonly IConsLi2Co3Repository _repository;
        private readonly IMapper _mapper;

        public ConsLi2Co3Service(IConsLi2Co3Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsLi2Co3Model> CreateConsLi2Co3(ConsLi2Co3Model model, string userName)
        {
            var result = _mapper.Map<ConsLi2Co3>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsLi2Co3 = result.IdConsLi2Co3;
            return model;
        }

        public async Task<List<ConsLi2Co3Model>> ReadConsLi2Co3()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsLi2Co3Model>>(data);

            return result;
        }

        public async Task UpdateConsLi2Co3(ConsLi2Co3Model model, string userName)
        {
            var result = _mapper.Map<ConsLi2Co3>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsLi2Co3(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsLi2Co3Model> ReadConsLi2Co3(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsLi2Co3Model>(model);
            return result;
        }

        #endregion
    }
}