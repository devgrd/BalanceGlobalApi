
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsPlantaLiOhService
    {
        Task<ConsPlantaLiOhModel> CreateConsPlantaLiOh(ConsPlantaLiOhModel ConsPlantaLiOhModel, string userName);
        Task<List<ConsPlantaLiOhModel>> ReadConsPlantaLiOh();
        Task UpdateConsPlantaLiOh(ConsPlantaLiOhModel ConsPlantaLiOhModel, string userName);
        Task DeleteConsPlantaLiOh(int id, string userName);
        Task<ConsPlantaLiOhModel> ReadConsPlantaLiOh(int id);
    }
    public class ConsPlantaLiOhService : IConsPlantaLiOhService
    {
        private readonly IConsPlantaLiOhRepository _repository;
        private readonly IMapper _mapper;

        public ConsPlantaLiOhService(IConsPlantaLiOhRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsPlantaLiOhModel> CreateConsPlantaLiOh(ConsPlantaLiOhModel model, string userName)
        {
            var result = _mapper.Map<ConsPlantaLiOh>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsPlantaLiOh = result.IdConsPlantaLiOh;
            return model;
        }

        public async Task<List<ConsPlantaLiOhModel>> ReadConsPlantaLiOh()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsPlantaLiOhModel>>(data);

            return result;
        }

        public async Task UpdateConsPlantaLiOh(ConsPlantaLiOhModel model, string userName)
        {
            var result = _mapper.Map<ConsPlantaLiOh>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsPlantaLiOh(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsPlantaLiOhModel> ReadConsPlantaLiOh(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsPlantaLiOhModel>(model);
            return result;
        }

        #endregion
    }
}