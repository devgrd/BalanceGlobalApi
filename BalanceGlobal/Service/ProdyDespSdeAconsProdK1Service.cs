
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IProdyDespSdeAconsProdK1Service
    {
        Task<ProdyDespSdeAconsProdK1Model> CreateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model ProdyDespSdeAconsProdK1Model, string userName);
        Task<List<ProdyDespSdeAconsProdK1Model>> ReadProdyDespSdeAconsProdK1();
        Task UpdateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model ProdyDespSdeAconsProdK1Model, string userName);
        Task DeleteProdyDespSdeAconsProdK1(int id, string userName);
        Task<ProdyDespSdeAconsProdK1Model> ReadProdyDespSdeAconsProdK1(int id);
    }
    public class ProdyDespSdeAconsProdK1Service : IProdyDespSdeAconsProdK1Service
    {
        private readonly IProdyDespSdeAconsProdK1Repository _repository;
        private readonly IMapper _mapper;

        public ProdyDespSdeAconsProdK1Service(IProdyDespSdeAconsProdK1Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ProdyDespSdeAconsProdK1Model> CreateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model model, string userName)
        {
            var result = _mapper.Map<ProdyDespSdeAconsProdK1>(model);
            await _repository.AddAsync(result, userName);
            model.IdProdyDespSdeAconsProdK1 = result.IdProdyDespSdeAconsProdK1;
            return model;
        }

        public async Task<List<ProdyDespSdeAconsProdK1Model>> ReadProdyDespSdeAconsProdK1()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ProdyDespSdeAconsProdK1Model>>(data);

            return result;
        }

        public async Task UpdateProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model model, string userName)
        {
            var result = _mapper.Map<ProdyDespSdeAconsProdK1>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteProdyDespSdeAconsProdK1(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ProdyDespSdeAconsProdK1Model> ReadProdyDespSdeAconsProdK1(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ProdyDespSdeAconsProdK1Model>(model);
            return result;
        }

        #endregion
    }
}