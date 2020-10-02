
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPciacopiosCliService
    {
        Task<PciacopiosCliModel> CreatePciacopiosCli(PciacopiosCliModel PciacopiosCliModel, string userName);
        Task<List<PciacopiosCliModel>> ReadPciacopiosCli();
        Task UpdatePciacopiosCli(PciacopiosCliModel PciacopiosCliModel, string userName);
        Task DeletePciacopiosCli(int id, string userName);
        Task<PciacopiosCliModel> ReadPciacopiosCli(int id);
    }
    public class PciacopiosCliService : IPciacopiosCliService
    {
        private readonly IPciacopiosCliRepository _repository;
        private readonly IMapper _mapper;

        public PciacopiosCliService(IPciacopiosCliRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<PciacopiosCliModel> CreatePciacopiosCli(PciacopiosCliModel model, string userName)
        {
            var result = _mapper.Map<PciacopiosCli>(model);
            await _repository.AddAsync(result, userName);
            model.IdPciacopiosCli = result.IdPciacopiosCli;
            return model;
        }

        public async Task<List<PciacopiosCliModel>> ReadPciacopiosCli()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PciacopiosCliModel>>(data);

            return result;
        }

        public async Task UpdatePciacopiosCli(PciacopiosCliModel model, string userName)
        {
            var result = _mapper.Map<PciacopiosCli>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeletePciacopiosCli(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<PciacopiosCliModel> ReadPciacopiosCli(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PciacopiosCliModel>(model);
            return result;
        }

        #endregion
    }
}