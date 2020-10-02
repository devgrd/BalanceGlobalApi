
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICorrientesRilesyRisesService
    {
        Task<CorrientesRilesyRisesModel> CreateCorrientesRilesyRises(CorrientesRilesyRisesModel CorrientesRilesyRisesModel, string userName);
        Task<List<CorrientesRilesyRisesModel>> ReadCorrientesRilesyRises();
        Task UpdateCorrientesRilesyRises(CorrientesRilesyRisesModel CorrientesRilesyRisesModel, string userName);
        Task DeleteCorrientesRilesyRises(int id, string userName);
        Task<CorrientesRilesyRisesModel> ReadCorrientesRilesyRises(int id);
    }
    public class CorrientesRilesyRisesService : ICorrientesRilesyRisesService
    {
        private readonly ICorrientesRilesyRisesRepository _repository;
        private readonly IMapper _mapper;

        public CorrientesRilesyRisesService(ICorrientesRilesyRisesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CorrientesRilesyRisesModel> CreateCorrientesRilesyRises(CorrientesRilesyRisesModel model, string userName)
        {
            var result = _mapper.Map<CorrientesRilesyRises>(model);
            await _repository.AddAsync(result, userName);
            model.IdCorrientesRilesyRises = result.IdCorrientesRilesyRises;
            return model;
        }

        public async Task<List<CorrientesRilesyRisesModel>> ReadCorrientesRilesyRises()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CorrientesRilesyRisesModel>>(data);

            return result;
        }

        public async Task UpdateCorrientesRilesyRises(CorrientesRilesyRisesModel model, string userName)
        {
            var result = _mapper.Map<CorrientesRilesyRises>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCorrientesRilesyRises(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CorrientesRilesyRisesModel> ReadCorrientesRilesyRises(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CorrientesRilesyRisesModel>(model);
            return result;
        }

        #endregion
    }
}