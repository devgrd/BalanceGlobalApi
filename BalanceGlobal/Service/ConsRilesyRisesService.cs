
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IConsRilesyRisesService
    {
        Task<ConsRilesyRisesModel> CreateConsRilesyRises(ConsRilesyRisesModel ConsRilesyRisesModel, string userName);
        Task<List<ConsRilesyRisesModel>> ReadConsRilesyRises();
        Task UpdateConsRilesyRises(ConsRilesyRisesModel ConsRilesyRisesModel, string userName);
        Task DeleteConsRilesyRises(int id, string userName);
        Task<ConsRilesyRisesModel> ReadConsRilesyRises(int id);
    }
    public class ConsRilesyRisesService : IConsRilesyRisesService
    {
        private readonly IConsRilesyRisesRepository _repository;
        private readonly IMapper _mapper;

        public ConsRilesyRisesService(IConsRilesyRisesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ConsRilesyRisesModel> CreateConsRilesyRises(ConsRilesyRisesModel model, string userName)
        {
            var result = _mapper.Map<ConsRilesyRises>(model);
            await _repository.AddAsync(result, userName);
            model.IdConsRilesyRises = result.IdConsRilesyRises;
            return model;
        }

        public async Task<List<ConsRilesyRisesModel>> ReadConsRilesyRises()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ConsRilesyRisesModel>>(data);

            return result;
        }

        public async Task UpdateConsRilesyRises(ConsRilesyRisesModel model, string userName)
        {
            var result = _mapper.Map<ConsRilesyRises>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteConsRilesyRises(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ConsRilesyRisesModel> ReadConsRilesyRises(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ConsRilesyRisesModel>(model);
            return result;
        }

        #endregion
    }
}