
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IProdyDespSdeAvariablesNumService
    {
        Task<ProdyDespSdeAvariablesNumModel> CreateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel ProdyDespSdeAvariablesNumModel, string userName);
        Task<List<ProdyDespSdeAvariablesNumModel>> ReadProdyDespSdeAvariablesNum();
        Task UpdateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel ProdyDespSdeAvariablesNumModel, string userName);
        Task DeleteProdyDespSdeAvariablesNum(int id, string userName);
        Task<ProdyDespSdeAvariablesNumModel> ReadProdyDespSdeAvariablesNum(int id);
    }
    public class ProdyDespSdeAvariablesNumService : IProdyDespSdeAvariablesNumService
    {
        private readonly IProdyDespSdeAvariablesNumRepository _repository;
        private readonly IMapper _mapper;

        public ProdyDespSdeAvariablesNumService(IProdyDespSdeAvariablesNumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ProdyDespSdeAvariablesNumModel> CreateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel model, string userName)
        {
            var result = _mapper.Map<ProdyDespSdeAvariablesNum>(model);
            await _repository.AddAsync(result, userName);
            model.IdProdyDespSdeAvariablesNum = result.IdProdyDespSdeAvariablesNum;
            return model;
        }

        public async Task<List<ProdyDespSdeAvariablesNumModel>> ReadProdyDespSdeAvariablesNum()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ProdyDespSdeAvariablesNumModel>>(data);

            return result;
        }

        public async Task UpdateProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel model, string userName)
        {
            var result = _mapper.Map<ProdyDespSdeAvariablesNum>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteProdyDespSdeAvariablesNum(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ProdyDespSdeAvariablesNumModel> ReadProdyDespSdeAvariablesNum(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ProdyDespSdeAvariablesNumModel>(model);
            return result;
        }

        #endregion
    }
}