
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IProdyDespSdeAconsProdKService
    {
        Task<ProdyDespSdeAconsProdKModel> CreateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel ProdyDespSdeAconsProdKModel, string userName);
        Task<List<ProdyDespSdeAconsProdKModel>> ReadProdyDespSdeAconsProdK();
        Task UpdateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel ProdyDespSdeAconsProdKModel, string userName);
        Task DeleteProdyDespSdeAconsProdK(int id, string userName);
        Task<ProdyDespSdeAconsProdKModel> ReadProdyDespSdeAconsProdK(int id);
    }
    public class ProdyDespSdeAconsProdKService : IProdyDespSdeAconsProdKService
    {
        private readonly IProdyDespSdeAconsProdKRepository _repository;
        private readonly IMapper _mapper;

        public ProdyDespSdeAconsProdKService(IProdyDespSdeAconsProdKRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ProdyDespSdeAconsProdKModel> CreateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel model, string userName)
        {
            var result = _mapper.Map<ProdyDespSdeAconsProdK>(model);
            await _repository.AddAsync(result, userName);
            model.IdProdyDespSdeAconsProdK = result.IdProdyDespSdeAconsProdK;
            return model;
        }

        public async Task<List<ProdyDespSdeAconsProdKModel>> ReadProdyDespSdeAconsProdK()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ProdyDespSdeAconsProdKModel>>(data);

            return result;
        }

        public async Task UpdateProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel model, string userName)
        {
            var result = _mapper.Map<ProdyDespSdeAconsProdK>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteProdyDespSdeAconsProdK(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ProdyDespSdeAconsProdKModel> ReadProdyDespSdeAconsProdK(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ProdyDespSdeAconsProdKModel>(model);
            return result;
        }

        #endregion
    }
}