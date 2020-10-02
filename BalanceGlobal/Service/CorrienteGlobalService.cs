
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICorrienteGlobalService
    {
        Task<CorrienteGlobalModel> CreateCorrienteGlobal(CorrienteGlobalModel CorrienteGlobalModel, string userName);
        Task<List<CorrienteGlobalModel>> ReadCorrienteGlobal();
        Task UpdateCorrienteGlobal(CorrienteGlobalModel CorrienteGlobalModel, string userName);
        Task DeleteCorrienteGlobal(int id, string userName);
        Task<CorrienteGlobalModel> ReadCorrienteGlobal(int id);
    }
    public class CorrienteGlobalService : ICorrienteGlobalService
    {
        private readonly ICorrienteGlobalRepository _repository;
        private readonly IMapper _mapper;

        public CorrienteGlobalService(ICorrienteGlobalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CorrienteGlobalModel> CreateCorrienteGlobal(CorrienteGlobalModel model, string userName)
        {
            var result = _mapper.Map<CorrienteGlobal>(model);
            await _repository.AddAsync(result, userName);
            model.IdCorrienteGlobal = result.IdCorrienteGlobal;
            return model;
        }

        public async Task<List<CorrienteGlobalModel>> ReadCorrienteGlobal()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CorrienteGlobalModel>>(data);

            return result;
        }

        public async Task UpdateCorrienteGlobal(CorrienteGlobalModel model, string userName)
        {
            var result = _mapper.Map<CorrienteGlobal>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCorrienteGlobal(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CorrienteGlobalModel> ReadCorrienteGlobal(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CorrienteGlobalModel>(model);
            return result;
        }

        #endregion
    }
}