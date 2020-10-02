
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITipoPciService
    {
        Task<TipoPciModel> CreateTipoPci(TipoPciModel TipoPciModel, string userName);
        Task<List<TipoPciModel>> ReadTipoPci();
        Task UpdateTipoPci(TipoPciModel TipoPciModel, string userName);
        Task DeleteTipoPci(int id, string userName);
        Task<TipoPciModel> ReadTipoPci(int id);
    }
    public class TipoPciService : ITipoPciService
    {
        private readonly ITipoPciRepository _repository;
        private readonly IMapper _mapper;

        public TipoPciService(ITipoPciRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<TipoPciModel> CreateTipoPci(TipoPciModel model, string userName)
        {
            var result = _mapper.Map<TipoPci>(model);
            await _repository.AddAsync(result, userName);
            model.IdTipoPci = result.IdTipoPci;
            return model;
        }

        public async Task<List<TipoPciModel>> ReadTipoPci()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TipoPciModel>>(data);

            return result;
        }

        public async Task UpdateTipoPci(TipoPciModel model, string userName)
        {
            var result = _mapper.Map<TipoPci>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteTipoPci(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<TipoPciModel> ReadTipoPci(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TipoPciModel>(model);
            return result;
        }

        #endregion
    }
}