
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICorrientePciService
    {
        Task<CorrientePciModel> CreateCorrientePci(CorrientePciModel CorrientePciModel, string userName);
        Task<List<CorrientePciModel>> ReadCorrientePci();
        Task UpdateCorrientePci(CorrientePciModel CorrientePciModel, string userName);
        Task DeleteCorrientePci(int id, string userName);
        Task<CorrientePciModel> ReadCorrientePci(int id);
    }
    public class CorrientePciService : ICorrientePciService
    {
        private readonly ICorrientePciRepository _repository;
        private readonly IMapper _mapper;

        public CorrientePciService(ICorrientePciRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CorrientePciModel> CreateCorrientePci(CorrientePciModel model, string userName)
        {
            var result = _mapper.Map<CorrientePci>(model);
            await _repository.AddAsync(result, userName);
            model.IdCorrientePci = result.IdCorrientePci;
            return model;
        }

        public async Task<List<CorrientePciModel>> ReadCorrientePci()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CorrientePciModel>>(data);

            return result;
        }

        public async Task UpdateCorrientePci(CorrientePciModel model, string userName)
        {
            var result = _mapper.Map<CorrientePci>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCorrientePci(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CorrientePciModel> ReadCorrientePci(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CorrientePciModel>(model);
            return result;
        }

        #endregion
    }
}